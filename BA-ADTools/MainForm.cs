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
    public partial class MainForm : Form
    {
        public List<string> stResults = new List<string>();
        public List<string> nmResults = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //readButton.PerformClick();
        }

        public void loadResults()
        {
            lbCount.Text = "0";
            progressBar.Style = ProgressBarStyle.Marquee;
            DirectorySearcher dsearch = new DirectorySearcher();
            dsearch.PropertiesToLoad.Add("DisplayName");
            dsearch.Asynchronous = true;
            dsearch.Filter = "(&(objectClass=user)(!(objectClass=computer)))";
            dsearch.CacheResults = false;
            SearchResultCollection results = dsearch.FindAll();
            stResults.Clear();
            nmResults.Clear();
            foreach (SearchResult result in results)
            {
                stResults.Add(result.Path);
                DirectoryEntry entry = result.GetDirectoryEntry();
                nmResults.Add(entry.Properties["CN"].Value.ToString());
                lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
                statusBar.Update();
            }
            drawResults();
            progressBar.Style = ProgressBarStyle.Blocks;
        }

        private void filterBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == char.Parse("\r"))
            //{
             
            //}
        }

        public void drawResults(string filter = "")
        {
            listBox1.Hide();
            listBox1.Items.Clear();
            lbCount.Text = "0";
            foreach (string result in nmResults)
            {
                if (filter.Equals("") || result.ToLower().Contains(filter.ToLower()))
                {
                    lbCount.Text = (int.Parse(lbCount.Text) + 1).ToString();
                    statusBar.Update();
                    listBox1.Items.Add(result);
                }
            }
            listBox1.Show();
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            drawResults(filterBox.Text);
        }
    }
}
