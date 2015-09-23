using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class CardInfo
    {
        [JsonProperty("client_first_name")]
        public string ClientFirstName
        {
            get;
            set;
        }
        [JsonProperty("client_last_name")]
        public string ClientLastName
        {
            get;
            set;
        }
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
        [JsonProperty("available_points")]
        public int AvailablePoints
        {
            get;
            set;
        }
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
        [JsonProperty("active")]

        public bool Active
        {
            get;
            set;
        }
    }
}
