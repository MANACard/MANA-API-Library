using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.OfflineAPI.Exceptions
{
    public class CouldNotSubmitSaleException : Exception
    {
        public CouldNotSubmitSaleException(Exception innerException) : base ("", innerException) { 
        
        }
    }
}
