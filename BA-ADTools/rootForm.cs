using System;
using System.ComponentModel;
using System.DirectoryServices;
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

        public delegate TreeNode addDelegate(TreeNodeCollection nodeCollection, string treeNodeName);
        public delegate void clearTreeDelegate(TreeNode node, int action);

        public void clearTree(TreeNode node, int action)
        {
            if(action == 0)
            {
                node.Nodes.Clear();
                node.Nodes.Add("Loading...");
                treeView.Refresh();
                treeView.BeginUpdate();
            }
            if(action == 1)
            {
                node.FirstNode.Remove();
                treeView.EndUpdate();
            }
        }

        public TreeNode addTreeNode(TreeNodeCollection nodeCollection, string treeNodeName)
        {
            return nodeCollection.Add(treeNodeName);
        }

        public bool fillNode(TreeNode node = null, DirectoryEntry dEntry = null, bool checkForChildren = false)
        {
            TreeView tree = null;
            bool hasChildren = false;
            if (dEntry == null)
            {
                dEntry = new DirectoryEntry();
            }
            if (node == null)
            {
                tree = treeView;
            }
            foreach (DirectoryEntry childDirEntry in dEntry.Children)
            {
                if (childDirEntry.SchemaClassName == "organizationalUnit" || childDirEntry.SchemaClassName == "Container")
                {
                    if (checkForChildren)
                    {
                        hasChildren = true;
                        break;
                    }
                    if (childDirEntry.Properties["name"].Count != 0)
                    {
                        TreeNodeCollection treeNodes;
                        if (tree == null)
                        {
                            treeNodes = node.Nodes;
                        }
                        else
                        {
                            treeNodes = tree.Nodes;
                        }
                        object[] args = new object[2];
                        args[0] = treeNodes;
                        args[1] = childDirEntry.Properties["name"][0].ToString();
                        IAsyncResult result = treeView.BeginInvoke(new addDelegate(addTreeNode), args);
                        TreeNode childTreeNode = (TreeNode)treeView.EndInvoke(result);
                        childTreeNode.Tag = childDirEntry;
                        if (fillNode(null, childDirEntry, true))
                        {
                            treeView.Invoke(new addDelegate(addTreeNode), new object[] { childTreeNode.Nodes, "" });
                        }
                    }
                }
            }
            if(node != null)
            {
                treeView.Invoke(new clearTreeDelegate(clearTree), new object[] { node, 1 });
            }
            return hasChildren;
        }

        private void rootForm_Load(object sender, EventArgs e)
        {
            treeWorker.RunWorkerAsync();
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(treeWorker.IsBusy)
            {
                e.Cancel = true;
            }
            else
            {
                treeWorker.RunWorkerAsync(new object[] { e.Node, (DirectoryEntry)e.Node.Tag });
            }
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
            if (mouseDown)
            {
                Left = e.X - mdX + Left;
                Top = e.Y - mdY + Top;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void treeWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            TreeNode node = null;
            DirectoryEntry entry = null;
            if (e.Argument != null)
            {
                object[] args = (object[])e.Argument;
                node = (TreeNode)args[0];
                entry = (DirectoryEntry)args[1];
                treeView.Invoke(new clearTreeDelegate(clearTree), new object[] { node, 0 });
            }
            fillNode(node, entry);
        }
    }
}
