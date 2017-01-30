using Mana.Cards.API.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Mana.Cards.OfflineAPI.Repositories
{
    public class JSONSaleRepository : ISaleRepository
    {

        private string Path { get; set; }
        public JSONSaleRepository()
        {
            this.Path = ConfigurationManager.AppSettings["OfflineAPI.StorageFolder"].ToString();
        }
        public void AddSale(API.Domain.Sale sale, string transactionId)
        {
            System.IO.Directory.CreateDirectory(this.Path);

            var path = String.Format("{0}\\{1}.unsynced", this.Path, Guid.NewGuid());

            sale.Redeem.Points = 0; // no redeem if offline

            var saleModel = new SaleModel()
            {
                TransactionId = transactionId,
                Sale = sale,
                Date = DateTime.Now
            };

            string obj = JsonConvert.SerializeObject(saleModel);

            File.WriteAllText(path, obj);
        }

        public IEnumerable<SaleModel> GetSales(bool deleteSales = true)
        {
            List<SaleModel> sales = new List<SaleModel>();
            foreach (var file in Directory.GetFiles(this.Path, "*.unsynced"))
            {
                string contents = File.ReadAllText(file);
                var model = JsonConvert.DeserializeObject<SaleModel>(contents);

                if (deleteSales)
                {
                    File.Delete(file);
                }
                sales.Add(model);
            }

            return sales;
        }

        public int GetUnsyncedCount()
        {
            return Directory.GetFiles(this.Path).Count();
        }
    }
}
