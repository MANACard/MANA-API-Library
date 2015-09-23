using Mana.Cards.API;
using Mana.Cards.API.Domain;
using Mana.Cards.API.Providers;
using StructureMap;
using StructureMap.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mana.Cards.Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
                try
                {
                    string path = args[0];
                    var sale = SaleLineItemsParser.GetSale(path);

                    if (args.Length > 1)
                    {
                        string posUser = args[1];

                        APISession.Instance.POSUSer = posUser;
                    }
                    //ag pass the filename also
                    Application.Run(new SalesForm(sale, Path.GetDirectoryName(path), path));
                }
                catch (Exception)
                {
                    Application.Run(new SalesCancellationForm());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
