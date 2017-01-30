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
                return String.Format("{0}{1}", Config.APIUrl, "/cards");
            }
        }

        public static string SalesEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, "/sales");
            }
        }

        public static string ClientsEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, "/clients");
            }
        }
        public static string ClientsCardResolveURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, "/cards/resolve");
            }
        }
        public static string ClientsSearchEndpointURL
        {
            get
            {
                return String.Format("{0}{1}", Config.APIUrl, "/clients/search");
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

        public static bool SpecifyTransactionAmount
        {
            get
            {
                bool result = false;
                if (ConfigurationManager.AppSettings["SpecifyTransactionAmount"] != null)
                {
                    Boolean.TryParse(ConfigurationManager.AppSettings["SpecifyTransactionAmount"], out result);
                }

                return result;
            }
        }

        public static string DefaultProductBarcode
        {
            get
            {
                string result = "";

                if (ConfigurationManager.AppSettings["DefaultProductBarcode"] != null)
                {
                    result = ConfigurationManager.AppSettings["DefaultProductBarcode"].ToString();
                }

                return result;
            }
        }

        public static string DefaultProductTitle
        {
            get
            {
                string result = "";

                if (ConfigurationManager.AppSettings["DefaultProductTitle"] != null)
                {
                    result = ConfigurationManager.AppSettings["DefaultProductTitle"].ToString();
                }

                return result;
            }
        }

        public static bool UseEmployeeCard
        {
            get
            {
                bool result = false;
                if (ConfigurationManager.AppSettings["UseEmployeeCard"] != null)
                {
                    Boolean.TryParse(ConfigurationManager.AppSettings["UseEmployeeCard"].ToString(), out result);
                }

                return result;
            }
        }
        public static string EmployeeCardLocation
        {
            get
            {
                if (ConfigurationManager.AppSettings["OfflineAPI.StorageFolder"] != null)
                {
                    return ConfigurationManager.AppSettings["OfflineAPI.StorageFolder"] + "\\.employee_card";
                }

                return "";
            }
        }
    }
}
