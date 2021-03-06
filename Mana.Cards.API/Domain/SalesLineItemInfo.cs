﻿using Newtonsoft.Json;
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

        [JsonProperty("actual_rewarded_points")]
        public decimal ActualRewardedPoints { get; set; }
        
        [JsonProperty("rewarded_value")]
        public decimal RewardedValue
        {
            get;
            set;
        }
        [JsonProperty("mana_commission")]
        public decimal ManaCommission { get; set; }

        [JsonProperty("item_identifier")]
        public string ItemIdentifier { get; set; }

        [JsonProperty("vat")]
        public int Vat { get; set; }

    }
}
