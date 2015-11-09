using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Mana.Cards.API.Domain;
using Mana.Cards.Client.Properties;

namespace Mana.Cards.Client
{
    public class CouponPrinter
    {
        #region Properties

        private string WriteToPath { get; set; }
        private string printFilename { get; set; }
        public SaleInfo SaleInfo { get; set; }
        
        #endregion

        #region CTORs

        public CouponPrinter(SaleInfo sale, string writeToPath, string clientName, 
            string acctualPoints, string payed, string cardNo, bool openPrintedCoupon, bool printOnCollect, bool printOnRedeem)
        {
            WriteToPath = writeToPath;
            PrintAndSave(sale, writeToPath, clientName, acctualPoints, payed, cardNo, openPrintedCoupon, printOnCollect, printOnRedeem);
        }

      

        private Image PrintAndSave(SaleInfo saleInfo, string writeToPath,
            string clientName, string actualPoint, string payed, string cardNo, bool openPrintedCoupon, bool printOnCollect, bool printOnRedeem)
        {

            Image bitmap = Resources.Kuponi;
            using (bitmap)
            using (var graphics = Graphics.FromImage(bitmap))
            using (var font = new Font("Arial", 7, FontStyle.Regular))
            {
                //data dhe ora
                graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), font,
                    Brushes.Black, 90, 270);

                //fatura id
                graphics.DrawString(saleInfo.Id.ToString(), font, Brushes.Black, 515, 267);

                //Emri dhe mbiemri
                graphics.DrawString(clientName, font, Brushes.Black, 180, 315);

                //nr karteles
                graphics.DrawString(cardNo.ToUpper(), font, Brushes.Black, 260, 350);


                //PAGESA
                graphics.DrawString(payed,font, Brushes.Black, 580, 520);

                //PIKET VLERA MONETARE
                graphics.DrawString(saleInfo.RedeemedMonetaryValue.ToString("C", CultureInfo.GetCultureInfo("de-DE")),
                font, Brushes.Black, 580, 555);


                //TOTALI
                graphics.DrawString(saleInfo.Total.ToString("C", CultureInfo.GetCultureInfo("de-DE")),
                font, Brushes.Black, 580, 600);

                //GJENDJA E PIKEVE

                var availablePoints = Convert.ToInt32(actualPoint);

                var previousPoints = (availablePoints + saleInfo.RedeemedPoints) - saleInfo.RewardedPoints;

                graphics.DrawString(previousPoints.ToString(),
                  new Font("Arial", 7, FontStyle.Bold), Brushes.Black, 580, 770);

                //PIKE TE PERDORURA
                //-150 (1.5 euro)
                graphics.DrawString(string.Format("-{0} ({1})", saleInfo.RedeemedPoints,
                    saleInfo.RedeemedMonetaryValue.ToString("C", CultureInfo.GetCultureInfo("de-DE"))), font,
                    Brushes.Black, 580, 815);

                //PIKE TE FITUARA
                graphics.DrawString(saleInfo.RewardedPoints.ToString(), font, Brushes.Black, 580, 855);

                //GJENDJA E RE E PIKEVE
              
                graphics.DrawString(actualPoint,
                    new Font("Arial", 7, FontStyle.Bold), Brushes.Black, 580, 895);


                // ruje qele printo ne default printer
                var filename = Path.Combine(writeToPath, string.Format("{0}.jpg", saleInfo.Id));
                printFilename = filename;

                bitmap.Save(filename);

                


                if (saleInfo.RedeemedPoints != 0 && printOnRedeem)
                {
                     PrintDocument pd = new PrintDocument();
                     pd.PrintPage += PrintPageEvent;
                     pd.Print();
                    
                    if (openPrintedCoupon)
                         Process.Start(filename);
                }
                else if (printOnCollect)
                {
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += PrintPageEvent;
                    pd.Print();

                    if (openPrintedCoupon)
                        Process.Start(filename);
                }

                


                //print
               

            }
            return bitmap;
        }

        #endregion

        private void PrintPageEvent(object o, PrintPageEventArgs e)
        {
            //            System.Drawing.Image img = System.Drawing.Image.FromFile(@"C:\555db2f1-0a04-481e-87b5-4f2551ee4aab.jpg");
            Image img = Image.FromFile(printFilename);
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);
            e.Graphics.DrawImage(img, 0,650);
            
        }

    }
}
