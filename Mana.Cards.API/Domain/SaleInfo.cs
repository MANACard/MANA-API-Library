using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class SaleInfo
    {
        [JsonProperty("id")]
        public UInt64 Id
        {
            get;
            set;
        }
        [JsonProperty("total")]
        public decimal Total
        {
            get;
            set;
        }
        [JsonProperty("rewarded_points")]
        public int RewardedPoints
        {
            get;
            set;
        }
        [JsonProperty("redeemed_points")]
        public int RedeemedPoints
        {
            get;
            set;
        }
        [JsonProperty("redeemed_value")]
        public decimal RedeemedMonetaryValue
        {
            get;
            set;
        }

        [JsonProperty("sales_line_items")]
        public List<SalesLineItemInfo> SalesLineItems { get; set; }
    }
}
