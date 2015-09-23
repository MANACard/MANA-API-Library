using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API
{
    public class APISession
    {
        private static APISession _session { get; set; }
        private APISession()
        {

        }

        public static APISession Instance
        {
            get
            {
                if (_session == null)
                    _session = new APISession();

                return _session;
            }
        }

        public string POSUSer { get; set; }
    }
}
