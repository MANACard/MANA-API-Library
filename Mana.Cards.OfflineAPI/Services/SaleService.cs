using Mana.Cards.API.Domain;
using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Services;
using Mana.Cards.OfflineAPI.Exceptions;
using Mana.Cards.OfflineAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Mana.Cards.OfflineAPI.Services
{
    public class SaleService : ISaleService
    {
        private ISaleRepository saleRepository;

        public SaleService()
        {
            saleRepository = new JSONSaleRepository();
        }
        public SaleInfo SubmitSale(Sale sale, string transactionId)
        {

            var saleService = new API.Services.SaleService();

            SubmitSaleDelegate s = saleService.SubmitSale;

            return this.ExecuteWithRetry(s, sale, transactionId);
        }

        private delegate SaleInfo SubmitSaleDelegate(Sale sale, string transactionId);


        /// <summary>
        /// Adapted from: http://stackoverflow.com/a/6956513/697567
        /// </summary>
        /// <param name="action"></param>
        private SaleInfo ExecuteWithRetry(SubmitSaleDelegate action, Sale sale, string transactionId)
        {
            const int maxRetries = 5;

            int attempts = 0;

            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    return action.Invoke(sale, transactionId);
                }
                catch (WebException ex)
                {
                    if ((maxRetries - i) == 1)
                    { // last iteration

                        this.saleRepository.AddSale(sale, transactionId);

                        throw new CouldNotSubmitSaleException(ex);
                    }

                    // Back-off and retry a bit later, don't just repeatedly hammer the connection
                    Thread.Sleep(SleepTime(attempts));
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return null;
        }

        private int SleepTime(int retryCount)
        {
            switch (retryCount)
            {
                case 0: return 0;
                case 1: return 500;
                case 2: return 1000;
                case 3: return 3000;
                default: return 5000;
            }
        }


        public IEnumerable<RecentSaleModel> GetRecentSales(string cardBarcode, int limit)
        {
            var saleService = new API.Services.SaleService();
            return saleService.GetRecentSales(cardBarcode, limit);
        }


        public bool CancelSale(int id, string cardBarcode, string phone)
        {
            var saleService = new API.Services.SaleService();

            return saleService.CancelSale(id, cardBarcode, phone);
        }

        public bool CancelSale(UInt64 id)
        {
            var saleService = new API.Services.SaleService();

            return saleService.CancelSale(id);
        }
    }
}
