using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;

namespace BAADTools
{
    static class Program
    {

        public static ADToolsSettings Settings = new ADToolsSettings();

        [STAThread]
        static void Main()
        {
            generateSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }

        public static void generateSettings()
        {
            if(Settings.domainSearchRoot == "")
            {
                DirectoryEntry RootDirEntry = new DirectoryEntry("LDAP://RootDSE");
                Settings.domainSearchRoot = "LDAP://" + RootDirEntry.Properties["defaultNamingContext"].Value;
                Settings.Save();
            }
        }

        public static Int64 convertFromLargeInt(object value)
        {
            var adsLargeInteger = value;
            var highPart = (Int32)adsLargeInteger.GetType().InvokeMember("HighPart", System.Reflection.BindingFlags.GetProperty, null, adsLargeInteger, null);
            var lowPart = (Int32)adsLargeInteger.GetType().InvokeMember("LowPart", System.Reflection.BindingFlags.GetProperty, null, adsLargeInteger, null);
            return highPart * ((Int64)UInt32.MaxValue + 1) + lowPart;
        }
    }
}
