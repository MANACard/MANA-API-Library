using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Domain
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]

        public decimal? Price { get; set; }
    }

    public class ProductsViewModel {
        [JsonProperty("products")]
        public IEnumerable<Product> Products { get; set;  }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        public bool HasNext() {
            double totalPages = Math.Ceiling((double) (Meta.TotalCount / Meta.Page));

            return ((int) totalPages) > Meta.Page;
        }

        public bool HasPrevious() {
            return Meta.Page > 1;
        }
    }
}
