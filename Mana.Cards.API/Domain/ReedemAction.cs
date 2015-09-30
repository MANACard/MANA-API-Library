using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class ReedemAction
    {
        [JsonProperty("points")]
        public int Points
        {
            get;
            set;
        }

        [JsonIgnore]
        public decimal Value
        { 
            get;
            set; 
        }
    }
}
