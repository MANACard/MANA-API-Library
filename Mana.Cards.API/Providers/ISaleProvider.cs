using Mana.Cards.API.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Providers
{
    public interface ISaleProvider
    {
        /// <summary>
        /// Used to retrieve latest sales from the POS system. 
        /// </summary>
        /// <returns>A collection of Sale objects</returns>
        IEnumerable<Sale> GetSales();

        /// <summary>
        /// Returns a particular Sale, identified by an id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Sale GetSale(string id);
    }
}
