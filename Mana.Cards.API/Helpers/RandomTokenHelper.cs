using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Helpers
{
    public class RandomTokenHelper
    {

        public static string GenerateToken() {
            return Guid.NewGuid().ToString();
        }
    }
}
