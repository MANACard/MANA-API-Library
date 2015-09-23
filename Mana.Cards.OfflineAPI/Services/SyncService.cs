using Mana.Cards.API.Exceptions;
using Mana.Cards.API.Services;
using Mana.Cards.OfflineAPI.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mana.Cards.OfflineAPI.Services
{
    public class SyncService
    {
        private ISaleRepository saleRepository;
        private ISaleService saleService;

        public SyncService()
        {
            saleRepository = new JSONSaleRepository();
            saleService = new SaleService();
        }
        public void StartSync() {
            var sales = saleRepository.GetSales();

            foreach (var item in sales) {
                try
                {
                    saleService.SubmitSale(item.Sale, item.TransactionId);
                }
                catch (SaleAlreadySubmittedException) { }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public IEnumerable<SaleModel> GetUnsyncedSales() {
            return saleRepository.GetSales(false);
        }
        public int GetUnsyncedCount()
        {
            return saleRepository.GetUnsyncedCount();
        }
    }
}
