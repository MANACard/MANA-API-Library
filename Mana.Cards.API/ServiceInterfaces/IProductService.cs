using Mana.Cards.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.ServiceInterfaces
{
    public interface IProductService
    {
        ProductsViewModel GetProducts(int page = 1, int per_page = 25, string searchText = "");

    }
}
