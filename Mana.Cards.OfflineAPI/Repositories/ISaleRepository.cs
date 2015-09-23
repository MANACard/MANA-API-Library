using Mana.Cards.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.OfflineAPI.Repositories
{
    public interface ISaleRepository
    {
        void AddSale(Sale s, string transactionId);

        IEnumerable<SaleModel> GetSales(bool deleteSales = true);

        int GetUnsyncedCount();
    }
}
