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

        public bool mouseDown = false;
        public int mdX = 0;
        public int mdY = 0;

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
            treeView.BeginUpdate();
            fillNode();
            treeView.EndUpdate();
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView.BeginUpdate();
            e.Node.Nodes.Clear();
            fillNode(e.Node, (DirectoryEntry)e.Node.Tag);
            treeView.EndUpdate();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            BAADTools.Settings.domainSearchRoot = selectedDirEntry.Path;
            BAADTools.Settings.Save();
            Close();
        }

        private void topBtn_Click(object sender, EventArgs e)
        {
            BAADTools.Settings.domainSearchRoot = "";
            BAADTools.generateSettings();
            Close();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedDirEntry = (DirectoryEntry)e.Node.Tag;
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mdX = e.X;
            mdY = e.Y;
        }

        private void titleBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                Left = e.X - mdX + Left;
                Top = e.Y - mdY + Top;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
