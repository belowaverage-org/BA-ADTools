using System;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

namespace BAADTools
{
    public partial class statusForm : Form
    {
        public statusForm()
        {
            InitializeComponent();
        }

        private void StatusBox_Load(object sender, EventArgs e)
        {
            Domain curDom = Domain.GetCurrentDomain();
            domBox.Text = curDom.Name;
            dcBox.Text = curDom.FindDomainController().Name;
            siteBox.Text = ActiveDirectorySite.GetComputerSite().Name;
            userBox.Text = Environment.UserName;
            dnBox.Text = Environment.UserDomainName;
        }
    }
}
