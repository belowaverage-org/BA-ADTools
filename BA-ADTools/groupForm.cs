using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Diagnostics;

namespace BAADTools
{
    public partial class groupForm : Form
    {
        public List<List<string>> allGroups = new List<List<string>>();

        public int liveResultsCount = 0;

        public Form parent;

        public groupForm(Form p)
        {
            InitializeComponent();
            parent = p;
        }
        
        public void reloadGroups()
        {
            progressBar.Style = ProgressBarStyle.Marquee;
            bgInit.RunWorkerAsync();
        }

        private void groupForm_Load(object sender, EventArgs e)
        {
            parent.Enabled = false;
            reloadGroups();
        }

        private void bgInit_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectorySearcher dSearch = new DirectorySearcher();
            dSearch.Filter = "objectClass=group";
            dSearch.Sort = new SortOption("cn", SortDirection.Ascending);
            dSearch.SearchRoot = new DirectoryEntry(Program.Settings.domainSearchRoot);
            dSearch.PageSize = 10000;
            dSearch.PropertiesToLoad.Add("cn");
            dSearch.PropertiesToLoad.Add("description");
            SearchResultCollection sResults = dSearch.FindAll();
            allGroups.Clear();
            liveResultsCount = 0;
            int max = sResults.Count;
            int count = 0;
            int lastProgReport = -1;
            foreach (SearchResult r in sResults)
            {
                List<string> nameDesc = new List<string>();
                nameDesc.Add(r.Properties["cn"][0].ToString());
                string desc = "";
                if (r.Properties["description"].Count != 0)
                {
                    desc = r.Properties["description"][0].ToString();
                }
                nameDesc.Add(desc);
                allGroups.Add(nameDesc);
                liveResultsCount = ++count;
                int prog = Convert.ToInt32((Convert.ToDouble(count) / Convert.ToDouble(max)) * 100);
                if (prog % 10 == 0 && prog != lastProgReport)
                {
                    lastProgReport = prog;
                    bgInit.ReportProgress(prog);
                }
            }
        }

        private void bgInit_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(progressBar.Style == ProgressBarStyle.Marquee)
            {
                progressBar.Style = ProgressBarStyle.Continuous;
            }
            progressBar.Value = e.ProgressPercentage;
            lbCount.Text = liveResultsCount.ToString();
        }

        private void bgInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbCount.Text = liveResultsCount.ToString();
            groupsList1.BeginUpdate();
            groupsList1.Items.Clear();
            foreach (List<string> group in allGroups)
            {
                groupsList1.Items.Add(group[0]).SubItems.Add(group[1]);
            }
            groupsList1.EndUpdate();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            if(!bgInit.IsBusy)
            {
                reloadGroups();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Enabled = true;
        }
    }
}
