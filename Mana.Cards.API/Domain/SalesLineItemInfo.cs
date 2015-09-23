using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class SalesLineItemInfo
    {
        [JsonProperty("product_title")]
        public string ProductTitle { get; set; }
     
        [JsonProperty("product_barcode")]
        public string ProductBarcode { get; set; }

        [JsonProperty("rewarded_points")]
        public int RewardedPoints { get; set; }
    }
}
