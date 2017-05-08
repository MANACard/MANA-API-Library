using Mana.Cards.API.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Mana.Cards.API.Helpers
{
    public class EmployeeCardStore
    {
        public string Get()
        {
            try
            {
                return System.IO.File.ReadAllText(Config.EmployeeCardLocation);
            }
            catch (Exception)
            {
                return "";
            }
        }

        public void Set(string barcode)
        {
            System.IO.File.WriteAllText(Config.EmployeeCardLocation, barcode);
        }

        private EmployeeCardStore()
        {

        }

        private static EmployeeCardStore _instance;
        public static EmployeeCardStore Instance
        {
            get {

                return _instance != null ? _instance : new EmployeeCardStore();
            }
        }
    }
}
