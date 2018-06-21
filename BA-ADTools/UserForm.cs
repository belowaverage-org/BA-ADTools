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
using System.DirectoryServices.AccountManagement;

namespace BAADTools
{
    public partial class userForm : Form
    {

        public Form parentForm;

        public string userDN;

        public System.DirectoryServices.PropertyCollection userProp;

        public UserPrincipal userPrinc;

        public DirectoryEntry userEntry;

        public int isPwExpired;

        public userForm(Form pf, string dn)
        {
            userDN = dn;
            parentForm = pf;
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            DNLabel.Text = userDN;
            backgroundProc.RunWorkerAsync();
        }

        private void backgroundProc_DoWork(object sender, DoWorkEventArgs e)
        {
            userEntry = new DirectoryEntry(userDN);
            PrincipalContext context = new PrincipalContext(ContextType.Domain);
            userProp = userEntry.Properties;
            userPrinc = UserPrincipal.FindByIdentity(context, IdentityType.DistinguishedName, userProp["distinguishedName"].Value.ToString());
            isPwExpired = BAADTools.isPasswordExpired(userProp["sAMAccountName"].Value.ToString());
        }

        private void backgroundProc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            Text = nameLb.Text = userPrinc.DisplayName;
            usernameLb.Text = userPrinc.SamAccountName;
            givenNameBox.Text = userPrinc.GivenName;
            initialsBox.Text = userPrinc.MiddleName;
            snBox.Text = userPrinc.Surname;
            numberBox.Text = userPrinc.VoiceTelephoneNumber;
            emailBox.Text = userPrinc.EmailAddress;

            if (userProp["streetAddress"].Count != 0)
                addressBox.Text = userProp["streetAddress"].Value.ToString();

            if (userProp["st"].Count != 0)
                stateBox.Text = userProp["st"].Value.ToString();

            if (userProp["co"].Count != 0)
                countryBox.Text = userProp["co"].Value.ToString();

            if (userProp["logonCount"].Count != 0)
                logonCountBox.Text = userProp["logonCount"].Value.ToString();

            if (userProp["thumbnailPhoto"].Count != 0)
            {
                Image thumbnailPhoto = (Bitmap)((new ImageConverter()).ConvertFrom(userProp["thumbnailPhoto"].Value));
                pictureBox.Image = thumbnailPhoto;
            }
            lockoutLight.ForeColor = Color.Green;
            if (userPrinc.IsAccountLockedOut())
            {
                lockoutLight.ForeColor = Color.Red;
            }
            enabledLight.ForeColor = Color.Green;
            if (!userPrinc.Enabled.Value)
            {
                enabledLight.ForeColor = Color.Red;
            }
            expiredLight.ForeColor = Color.Green;
            if(userPrinc.AccountExpirationDate != null)
            {
                DateTime expDate = userPrinc.AccountExpirationDate.Value;
                int compare = DateTime.Compare(DateTime.Now, expDate);
                if (compare == 0 || compare > 0)
                {
                    expiredLight.ForeColor = Color.Red;
                }
            }
            pChangeLight.ForeColor = Color.Green;
            if (isPwExpired == 1)
            {
                pChangeLight.ForeColor = Color.Red;
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form groupForm = new groupForm(this);
            groupForm.MdiParent = MdiParent;
            groupForm.Show();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            float xScale = (float) pictureBox.Width / pictureBox.Image.Width;
            float yScale = (float) pictureBox.Height / pictureBox.Image.Height;
            if(xScale > 1 || yScale > 1)
            {
                e.Graphics.Clear(Color.White);
                e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                e.Graphics.ScaleTransform(xScale, yScale);
                e.Graphics.DrawImage(pictureBox.Image, new PointF());
            }
        }
    }
}
