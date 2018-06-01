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

        public DirectoryEntry selectedDirEntry;

        public bool fillNode(TreeNode node = null, DirectoryEntry dEntry = null, bool checkForChildren = false)
        {
            TreeView tree = null;
            bool hasChildren = false;
            if (dEntry == null)
            {
                dEntry = new DirectoryEntry();
            }
            if(node == null)
            {
                tree = treeView;
            }
            foreach (DirectoryEntry childDirEntry in dEntry.Children)
            {
                if (childDirEntry.SchemaClassName == "organizationalUnit" || childDirEntry.SchemaClassName == "Container")
                {
                    if(checkForChildren)
                    {
                        hasChildren = true;
                        break;
                    }
                    if(childDirEntry.Properties["name"].Count != 0)
                    {
                        TreeNodeCollection treeNodes;
                        if(tree == null)
                        {
                            treeNodes = node.Nodes;
                        }
                        else
                        {
                            treeNodes = tree.Nodes;
                        }
                        TreeNode childTreeNode = treeNodes.Add(childDirEntry.Properties["name"][0].ToString());
                        childTreeNode.Tag = childDirEntry;
                        if (fillNode(null, childDirEntry, true))
                        {
                            childTreeNode.Nodes.Add("");
                        }
                    }
                }
            }
            return hasChildren;
        }

        private void rootForm_Load(object sender, EventArgs e)
        {
            fillNode();
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            fillNode(e.Node, (DirectoryEntry)e.Node.Tag);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Settings.domainSearchRoot = selectedDirEntry.Path;
            Close();
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            DirectoryEntry RootDirEntry = new DirectoryEntry("LDAP://RootDSE");
            Settings.domainSearchRoot = "LDAP://" + RootDirEntry.Properties["defaultNamingContext"].Value;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedDirEntry = (DirectoryEntry)e.Node.Tag;
        }
    }
}
