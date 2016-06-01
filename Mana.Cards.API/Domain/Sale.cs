using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class Sale
    {
        public Sale()
        {
            Redeem = new ReedemAction();
        }

        /// <summary>
        /// Put here the transaction id of the sale you want to overwrite.
        /// </summary>
        [JsonProperty("sale_id", NullValueHandling = NullValueHandling.Ignore)]
        public UInt64? Id { get; set; }


        [JsonProperty("card_barcode")]
        public string CardBarcode
        {
            get;
            set;
        }

        [JsonProperty("employee_card_barcode")]
        public string EmployeeCardBarcode
        {
            get;
            set;
        }
        [JsonIgnore]
        public decimal Total
        {
            get
            {
                return this.Items != null ? Items.Select(x => x.Quantity * x.Price).Sum() : 0;
            }
        }
        [JsonProperty("items")]

        public List<SalesLineItem> Items { get; set; }

        [JsonProperty("redeem")]
        public ReedemAction Redeem { get; set; }

        [JsonIgnore]
        public SaleDescriptor SaleDescriptor { get; set; }
    }
}
