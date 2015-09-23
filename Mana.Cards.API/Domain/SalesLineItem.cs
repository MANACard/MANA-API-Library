using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class SalesLineItem
    {
        [JsonProperty("barcode")]
        public string Barcode
        {
            get;
            set;
        }

        [JsonProperty("category")]
        public string Category
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }
        
        [JsonProperty("quantity")]
        public decimal Quantity
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public decimal Price
        {
            get;
            set;
        }
    }
}
