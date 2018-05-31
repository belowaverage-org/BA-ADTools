using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAADTools
{
    public partial class UserForm : Form
    {

        public Form parentForm;

        public string userDN;

        public System.DirectoryServices.PropertyCollection userProp;

        public UserForm(Form pf, string dn)
        {
            userDN = dn;
            parentForm = pf;
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Point parentFormCords = parentForm.Location;
            parentFormCords.X = parentFormCords.X + parentForm.Width;
            Location = parentFormCords;
            DNLabel.Text = userDN;
            backgroundProc.RunWorkerAsync();
        }

        private void backgroundProc_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryEntry user = new DirectoryEntry(userDN);
            userProp = user.Properties;
        }

        private void backgroundProc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (userProp["cn"].Count != 0)
                Text = nameLb.Text = userProp["cn"].Value.ToString();
            
            if (userProp["sAMAccountName"].Count != 0)
                usernameLb.Text = userProp["sAMAccountName"].Value.ToString();
            
            if (userProp["givenName"].Count != 0)
                givenNameBox.Text = userProp["givenName"].Value.ToString();

            if (userProp["initials"].Count != 0)
                initialsBox.Text = userProp["initials"].Value.ToString();

            if (userProp["sn"].Count != 0)
                snBox.Text = userProp["sn"].Value.ToString();

            if (userProp["telephoneNumber"].Count != 0)
                numberBox.Text = userProp["telephoneNumber"].Value.ToString();

            if (userProp["mail"].Count != 0)
                emailBox.Text = userProp["mail"].Value.ToString();

            if (userProp["streetAddress"].Count != 0)
                addressBox.Text = userProp["streetAddress"].Value.ToString();

            if (userProp["st"].Count != 0)
                stateBox.Text = userProp["st"].Value.ToString();

            if (userProp["givenName"].Count != 0)
                givenNameBox.Text = userProp["givenName"].Value.ToString();

            if (userProp["co"].Count != 0)
                countryBox.Text = userProp["co"].Value.ToString();

        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new groupForm(this).Show();
        }
    }
}
