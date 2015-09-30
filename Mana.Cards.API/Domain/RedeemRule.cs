using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class RedeemRule
    {
        [JsonProperty("minimum_redeemable_points")]

        public int MinimumRedeemablePoints
        {
            get;
            set;
        }
        [JsonProperty("monetary_value_per_point")]

        public decimal MonetaryValuePerPoint
        {
            get;
            set;
        }
    }
}
