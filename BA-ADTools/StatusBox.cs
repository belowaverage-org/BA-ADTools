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
    public partial class StatusBox : Form
    {
        public StatusBox()
        {
            InitializeComponent();
        }

        private void StatusBox_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain().Name);
        }
    }
}
