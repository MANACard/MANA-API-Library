using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class Client
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("first_name")]
        public string Firstname { get; set; }
        [JsonProperty("last_name")]
        public string Lastname { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        [JsonProperty("birth_date")]
        public DateTime? Birthdate { get; set; }
        public int? City { get; set; }

        [JsonProperty("point_of_sale_password")]
        public string PointOfSalePassword { get; set; }

        [JsonProperty("business")]
        public bool Business { get; set; }
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
        [JsonProperty("business_type")]
        public string BusinessType { get; set; }


        [JsonProperty("employee_card_barcode")]
        public string EmployeeCardBarcode { get; set; }
    }
}
