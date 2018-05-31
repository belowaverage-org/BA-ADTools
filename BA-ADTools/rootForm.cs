using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace BAADTools
{
    public partial class rootForm : Form
    {
        public rootForm()
        {
            InitializeComponent();
        }

        public void fillFromRoot(TreeNode node = null, DirectoryEntry dEntry = null)
        {
            if(dEntry == null)
            {
                dEntry = new DirectoryEntry();
            }
            if(node == null)
            {
                node = treeView.TopNode;
            }
            foreach (DirectoryEntry child in dEntry.Children)
            {
                if (child.SchemaClassName == "organizationalUnit" || child.SchemaClassName == "Container")
                {
                    node = node.Nodes.Add(child.Properties["name"][0].ToString());
                    fillFromRoot(node, child);
                }
            }
        }

        private void rootForm_Load(object sender, EventArgs e)
        {
            fillFromRoot();
        }
    }
}
