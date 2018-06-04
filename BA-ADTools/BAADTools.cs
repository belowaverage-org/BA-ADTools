using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Windows.Forms;

namespace BAADTools
{
    static class BAADTools
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
                Settings.domainSearchRoot = rootDirectoryDN();
                Settings.Save();
            }
        }

        public static string rootDirectoryDN()
        {
            DirectoryEntry RootDirEntry = new DirectoryEntry("LDAP://RootDSE");
            return "LDAP://" + RootDirEntry.Properties["defaultNamingContext"].Value;
        }

        public static Int64 convertFromLargeInt(object value)
        {
            var adsLargeInteger = value;
            var highPart = (Int32)adsLargeInteger.GetType().InvokeMember("HighPart", System.Reflection.BindingFlags.GetProperty, null, adsLargeInteger, null);
            var lowPart = (Int32)adsLargeInteger.GetType().InvokeMember("LowPart", System.Reflection.BindingFlags.GetProperty, null, adsLargeInteger, null);
            return highPart * ((Int64)UInt32.MaxValue + 1) + lowPart;
        }

        public static int isPasswordExpired(string userName)
        {
            using (var userEntry = new DirectoryEntry(string.Format("WinNT://{0}/{1},user", Environment.UserDomainName, userName)))
            {
                return (int)userEntry.Properties.Cast<PropertyValueCollection>().First(p => p.PropertyName == "PasswordExpired").Value;
            }
        }
    }
}
