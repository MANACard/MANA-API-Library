using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class Meta
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }
}
