﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
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
        public bool splitterMouseDown = false;
        public bool rootFormClosed = true;
        public FormWindowState OldFormWindowState;

        public Form rootForm;

        public Timer mdiActivateTimer = new Timer();
        public static Timer mdiLayoutTimer = new Timer();

        public mainForm()
        {
            InitializeComponent();
            runSearchWorker();
            mdiActivateTimer.Interval = 1;
            mdiActivateTimer.Tick += MdiActivateTimer_Tick;
            mdiLayoutTimer.Interval = 1;
            mdiLayoutTimer.Tick += MdiLayoutTimer_Tick;
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
            if(mainList.Items.Count != 0)
            {
                mainList.SetSelected(0, true);
            }
            mainList.EndUpdate();
        }

        public void openSelected()
        {
            Form userForm = new userForm(this, dnResults[mainList.SelectedIndex]);
            userForm.MdiParent = this;
            userForm.Show();
        }

        public static void sortMdiWindowsBasedOnSettings()
        {
            mdiLayoutTimer.Start();
        }

        private void MdiLayoutTimer_Tick(object sender, EventArgs e)
        {
            mdiLayoutTimer.Stop();
            //LayoutMdi(MdiLayout.TileVertical);
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
            Form aboutBox = new aboutBox();
            aboutBox.MdiParent = this;
            aboutBox.Show();
        }

        private void aboutBelowAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://belowaverage.org/");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form statusForm = new statusForm();
            statusForm.MdiParent = this;
            statusForm.Show();
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
            if(rootFormClosed) {
                rootForm = new rootForm();
                rootForm.MdiParent = this;
                rootForm.Show();
                rootForm.FormClosed += RootForm_FormClosed;
                rootFormClosed = false;
            }
            else
            {
                rootForm.Focus();
            }
        }

        private void RootForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            rootFormClosed = true;
        }

        private void splitter_MouseDown(object sender, MouseEventArgs e)
        {
            splitterMouseDown = true;
        }

        private void splitter_MouseMove(object sender, MouseEventArgs e)
        {
            if (splitterMouseDown)
            {
                splitter.Width = e.X + 3;
                filterBox.Width = mainList.Width = e.X;
            }
        }

        private void splitter_MouseUp(object sender, MouseEventArgs e)
        {
            splitterMouseDown = false;
            sortMdiWindowsBasedOnSettings();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void minimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mainForm_MdiChildActivate(object sender, EventArgs e)
        {
            mdiActivateTimer.Start();
        }

        private void MdiActivateTimer_Tick(object sender, EventArgs e)
        {
            mdiActivateTimer.Stop();
            if (MdiChildren.Length > 0)
            {
                instrucLbl.Hide();
            }
            else
            {
                instrucLbl.Show();
            }
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (OldFormWindowState != WindowState)
            {
                OldFormWindowState = WindowState;
                if (WindowState == FormWindowState.Maximized)
                {
                    sortMdiWindowsBasedOnSettings();
                }
            }
        }
        
        private void mainForm_ResizeEnd(object sender, EventArgs e)
        {
            sortMdiWindowsBasedOnSettings();
        }
    }
}
