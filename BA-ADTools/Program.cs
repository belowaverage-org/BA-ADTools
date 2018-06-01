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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            generateSettings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }

        static void generateSettings()
        {
            DirectoryEntry RootDirEntry = new DirectoryEntry("LDAP://RootDSE");
            Settings.domainSearchRoot = "LDAP://" + RootDirEntry.Properties["defaultNamingContext"].Value;
        }
    }
    class Settings
    {
        public static string domainSearchRoot;
    }
}
