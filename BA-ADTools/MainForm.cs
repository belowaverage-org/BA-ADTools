﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Windows.Forms;

namespace BAADTools
{
    public partial class mainForm : Form
    {
        public List<string> dnResults = new List<string>();
        public List<string> nmResults = new List<string>();

        public int liveResultsCount = 0;

        public string filterString = "";

        public bool filterLocal = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Left = Left - 390;
            runSearchWorker();
        }

        public void runSearchWorker()
        {
            if (!searchWorker.IsBusy)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                searchWorker.RunWorkerAsync();
            }
        }

        private void filterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == char.Parse("\r"))
            {
                filterString = filterBox.Text;
                runSearchWorker();
            }
        }

        public void drawResults()
        {
            mainList.BeginUpdate();
            mainList.Items.Clear();
            foreach (string result in nmResults)
            {
                statusBar.Update();
                mainList.Items.Add(result);
            }
            mainList.EndUpdate();
        }

        public void openSelected()
        {
            new userForm(this, dnResults[mainList.SelectedIndex]).Show();
        }

        private void searchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectorySearcher dsearch = new DirectorySearcher();
            if (!filterString.Equals(""))
            {
                filterString = filterString + "*";
            }
            dsearch.Filter = "(&(objectClass=user)(displayName=*" + filterString + ")(!(objectClass=computer)))";//THE ASTERISK IS A PROBLEM
            dsearch.SearchRoot = new DirectoryEntry(BAADTools.Settings.domainSearchRoot);
            dsearch.PageSize = 10000;
            dsearch.PropertiesToLoad.Add("cn");
            dsearch.Sort = new SortOption("cn", SortDirection.Ascending);
            filterString = "";
            SearchResultCollection results = dsearch.FindAll();
            dnResults.Clear();
            nmResults.Clear();
            int max = results.Count;
            int count = 0;
            int lastProgReport = -1;
            foreach(SearchResult result in results)
            {
                liveResultsCount = ++count;
                int prog = Convert.ToInt32((Convert.ToDouble(count) / Convert.ToDouble(max)) * 100);
                if (result.Properties.Contains("cn"))
                {
                    dnResults.Add(result.Path);
                    nmResults.Add(result.Properties["cn"][0].ToString());
                }
                if(prog % 5 == 0 && prog != lastProgReport)
                {
                    lastProgReport = prog;
                    searchWorker.ReportProgress(prog);
                }
            }
        }

        private void searchWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(progressBar.Style == ProgressBarStyle.Marquee)
            {
                progressBar.Style = ProgressBarStyle.Continuous;
            }
            progressBar.Value = e.ProgressPercentage;
            lbCount.Text = liveResultsCount.ToString();
        }

        private void searchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            drawResults();
            if (mainList.Items.Count == 1)
            {
                mainList.SetSelected(0, true);
                openSelected();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutBAADToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new aboutBox().Show();
        }

        private void aboutBelowAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://belowaverage.org/");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new statusForm().Show();
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

        private void selectAWorkingOUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new rootForm().Show();
        }

    }
}
