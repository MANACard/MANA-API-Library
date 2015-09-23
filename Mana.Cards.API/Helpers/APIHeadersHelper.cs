using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Mana.Cards.API.Helpers
{
    public class APIHeadersHelper
    {
        public static void InjectAPIHeaders(WebHeaderCollection headers) {
            headers.Add("authorization", AuthenticationHelper.GetAuthString());
            headers.Add("mana-pos-user", APISession.Instance.POSUSer);
        }
    }
}
