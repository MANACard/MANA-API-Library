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
        [JsonProperty("card_barcode")]
        public string CardBarcode
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
