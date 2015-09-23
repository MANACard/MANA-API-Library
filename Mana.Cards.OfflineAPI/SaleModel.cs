using Mana.Cards.API.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.OfflineAPI
{
    public class SaleModel
    {
        [JsonProperty]
        public string TransactionId { get; set; }

        [JsonProperty]
        public DateTime Date { get; set; }

        [JsonProperty]
        public Sale Sale { get; set; }
    }
}
