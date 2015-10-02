using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Helpers
{
    public class Config
    {
        public static string APIUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["APIUrl"];
            }
        }

        public static string CitiesSearchURL
        {
            get
            {

                return ConfigurationManager.AppSettings["CitiesSearchURL"];
            }
        }

        public static string CardsEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, ConfigurationManager.AppSettings["CardsEndpoint"]);
            }
        }

        public static string SalesEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, ConfigurationManager.AppSettings["SalesEndpoint"]);
            }
        }

        public static string ClientsEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, ConfigurationManager.AppSettings["ClientsEndpoint"]);
            }
        }
        public static string ClientsCardResolveURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, ConfigurationManager.AppSettings["ClientsCardResolveEndpoint"]);
            }
        }
        public static string ClientsSearchEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, ConfigurationManager.AppSettings["ClientsSearchEndpoint"]);
            }
        }
        public static bool EnableOfflineAPI
        {
            get
            {
                bool enableOfflineAPI = true;

                Boolean.TryParse(ConfigurationManager.AppSettings["EnableOfflineAPI"], out enableOfflineAPI);

                return enableOfflineAPI;
            }
        }
        public static int DecimalScale
        {
            get
            {
                int scale = 2;
                if (ConfigurationManager.AppSettings["DecimalScale"] != null)
                {
                    Int32.TryParse(ConfigurationManager.AppSettings["DecimalScale"], out scale);
                }
                return scale;
            }
        }

    }
}
