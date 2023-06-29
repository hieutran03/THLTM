using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            string path = Application.StartupPath;
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                DirectoryInfo info = new DirectoryInfo(drive.Name);
                TreeNode driveNode = new TreeNode(info.Name);
                driveNode.Tag = info;
                GetDirectories(info.GetDirectories(), driveNode);
                treeView1.Nodes.Add(driveNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            try
            {
                TreeNode aNode;
                DirectoryInfo[] subSubDirs;
                foreach (DirectoryInfo subDir in subDirs)
                {
                    aNode = new TreeNode(subDir.Name, 0, 0);
                    aNode.Tag = subDir;
                    aNode.ImageKey = "folder";
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                    nodeToAddTo.Nodes.Add(aNode);
                }
            }
            catch
            {
                return;
            }
        }


        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode newSelected = e.Node;
                listView1.Items.Clear();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                        {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);
                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    listView1.Items.Add(item);
                }

                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            }
            catch
            {
                return;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
