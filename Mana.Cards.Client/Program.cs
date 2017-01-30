using Mana.Cards.API;
using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Helpers;
using Mana.Cards.API.Providers;
using Mana.Cards.API.Services;
using StructureMap;
using StructureMap.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mana.Cards.Client
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.XmlConfigurator.Configure();

            ProcessStartInfo startInfo = new ProcessStartInfo(@"Mana.Cards.OfflineAPI.exe");
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;

            Process.Start(startInfo);
            try
            {
                ObjectFactory.Initialize(x =>
                {
                    x.PullConfigurationFromAppConfig = true;
                });

                Application.Run(ObjectFactory.GetInstance<SalesProviderForm>());
            }
            catch (StructureMapConfigurationException e)
            {
                if (args.Length == 0)
                {
                    if (Config.SpecifyTransactionAmount)
                    {
                        var frm = new TransactionAmountForm();
                        var result = frm.ShowDialog();

                        if (result == DialogResult.OK)
                        {

                            var sale = frm.Sale;


                            Application.Run(new SalesForm(sale));
                        }
                       
                    }
                    else
                    {
                        Application.Run(new SaleProductsForm());
                    }


                }
                else
                {
                    if (args[0].ToLower() == "cancel")
                    {
                        ulong transactionId = 0;

                        UInt64.TryParse(args[1], out transactionId);

                        if (transactionId == 0)
                        {
                            MessageBox.Show("ID e shitjes eshte jo-valide", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            ISaleService service = new SaleService();

                            try
                            {
                                bool result = service.CancelSale(transactionId);

                                if (result)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Environment.Exit(500);
                                }
                            }
                            catch (UnauthorizedCancellationException)
                            {
                                Environment.Exit(403);
                            }
                        }
                    }
                    else
                    {
                        string path = args[0];
                        var sale = SaleLineItemsParser.GetSale(path);

                        if (args.Length > 1)
                        {
                            ulong transactionId = 0;

                            UInt64.TryParse(args[1], out transactionId);
                            sale.Id = transactionId;
                        }
                        Application.Run(new SalesForm(sale, Path.GetDirectoryName(path), path));
                    }
                }
            }
            catch (Exception e)
            {
                log.Error("MANA Client", e);
                MessageBox.Show(e.Message);
                Environment.Exit(500);
            }

        }
    }
}
