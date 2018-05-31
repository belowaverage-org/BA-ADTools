using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Windows.Forms;

namespace BAADTools
{
    public partial class MainForm : Form
    {
        public List<string> dnResults = new List<string>();
        public List<string> nmResults = new List<string>();

        public int liveResultsCount = 0;

        public string filterString = "";

        public bool filterLocal = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            queryServer.RunWorkerAsync();
        }

        private void filterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.Parse("\r"))
            {
                filterString = filterBox.Text;
                if(!queryServer.IsBusy)
                {
                    queryServer.RunWorkerAsync();
                }
            }
        }

        public void drawResults()
        {
            mainList.Hide();
            mainList.Items.Clear();
            lbCount.Text = "0";
            foreach (string result in nmResults)
            {
                if (filterString.Equals("") || result.ToLower().Contains(filterString.ToLower()))
                {
                    lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
                    statusBar.Update();
                    mainList.Items.Add(result);
                }
            }
            mainList.Show();
        }

        public void openSelected()
        {
            new UserForm(this, dnResults[mainList.SelectedIndex]).Show();
        }

        private void queryServer_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectorySearcher dsearch = new DirectorySearcher();
            if (!filterString.Equals(""))
            {
                filterString = filterString + "*";
            }
            dsearch.Filter = "(&(objectClass=user)(displayName=*" + filterString + ")(!(objectClass=computer)))";
            dsearch.Sort = new SortOption("cn", SortDirection.Ascending);
            filterString = "";
            dsearch.CacheResults = false;
            SearchResultCollection results = dsearch.FindAll();
            dnResults.Clear();
            nmResults.Clear();
            int max = results.Count;
            int count = 0;
            int lastProgReport = -1;
            foreach(SearchResult result in results)
            {
                liveResultsCount = count++;
                int prog = Convert.ToInt32((Convert.ToDouble(count) / Convert.ToDouble(max)) * 100);
                if (result.Properties.Contains("cn"))
                {
                    dnResults.Add(result.Path);
                    nmResults.Add(result.Properties["cn"][0].ToString());
                }
                if(prog % 5 == 0 && prog != lastProgReport)
                {
                    lastProgReport = prog;
                    queryServer.ReportProgress(prog);
                }
            }
        }

        private void queryServer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lbCount.Text = liveResultsCount.ToString();
        }

        private void queryServer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            drawResults();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutBAADToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void aboutBelowAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://belowaverage.org/");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new StatusBox().Show();
        }

        private void listBox1_DbCLick(object sender, EventArgs e)
        {
            openSelected();
        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == char.Parse("\r"))
            {
                openSelected();
            }
        }
    }
}
