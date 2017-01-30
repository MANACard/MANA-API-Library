using Mana.Cards.OfflineAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mana.Cards.OfflineAPI
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [STAThread]
        static void Main(String[] args) {
            log4net.Config.XmlConfigurator.Configure();

            try
            {
                var sync = new SyncService();
                sync.StartSync();  
            }
            catch (Exception e)
            {
                log.Error(e.ToString());
            }         
        }
    }
}
