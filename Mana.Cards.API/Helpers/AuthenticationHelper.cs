using Mana.Cards.API.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Helpers
{
    public class AuthenticationHelper
    {
        private static string Name;
        /// <summary>
        /// Returns an HTTP Basic Authentication string, based on auth_id and apikey inputs
        /// </summary>
        /// <param name="auth_id"></param>
        /// <param name="apikey"></param>
        /// <returns></returns>
        public static string GetAuthString(string auth_id, string apikey)
        {
            string _auth = String.Format("{0}:{1}", auth_id, apikey);
            string _enc = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(_auth));
            string _cred = string.Format("{0} {1}", "Basic", _enc);
            return _cred;
        }

        /// <summary>
        /// Returns an HTTP Basic Authentication string, based on the input values retrieved from Config
        /// </summary>
        /// <returns></returns>
        public static string GetAuthString()
        {
            return GetAuthString(ConfigurationManager.AppSettings["ManaAuthID"].ToString(),
                ConfigurationManager.AppSettings["ManaAPIKey"].ToString());
        }
        /// <summary>
        /// Returns the name of the partner + the point of sale name
        /// </summary>
        /// <returns></returns>
        public static string GetPartnerName()
        {
            if (Name == null)
            {
                Name = new PartnerService().GetMyName();
            }

            return Name;
        }
    }
}
