using Mana.Cards.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Services
{
    public interface ISaleService
    {
        /// <summary>
        /// Submits a sale to MANA API, and returns a SaleInfo object with the sale results
        /// </summary>
        /// <param name="sale">A sale object</param>
        /// <param name="transactionId">A random transaction id to ensure idempotence</param>
        /// <returns></returns>
        SaleInfo SubmitSale(Sale sale, string transactionId);

        /// <summary>
        /// Returns the recent sales submitted by this point of sale to MANA API
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        IEnumerable<RecentSaleModel> GetRecentSales(string cardBarcode, int limit);

        /// <summary>
        /// Cancels a sale by id, and card barcode and phone
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cardBarcode"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        bool CancelSale(int id, string cardBarcode, string phone);

        bool CancelSale(UInt64 id);
    }
}
