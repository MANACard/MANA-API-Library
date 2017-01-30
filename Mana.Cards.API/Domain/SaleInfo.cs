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
        [JsonProperty("available_points")]
        public decimal AvailablePoints
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
        [JsonProperty("actual_rewarded_points")]
        public decimal ActualRewardedPoints
        {
            get;
            set;
        }

        [JsonProperty("rewarded_value")]
        public decimal RewardedValue
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
        [JsonProperty("actual_redeemed_points")]
        public decimal ActualRedeemedPoints
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
        [JsonProperty("discount_value")]
        public decimal DiscountValue
        {
            get;
            set;
        }

        [JsonProperty("custom_message")]
        public string CustomMessage
        {
            get;
            set;
        }

        [JsonProperty("sales_line_items")]
        public List<SalesLineItemInfo> SalesLineItems { get; set; }
    }
}
