using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class RecentSaleModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transaction_id")]
        public ulong TransactionId { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }

        [JsonProperty("total_paid")]

        public decimal TotalPaid { get; set; }

        [JsonProperty("created_at")]
        public DateTime Date { get; set; }
    }
}
