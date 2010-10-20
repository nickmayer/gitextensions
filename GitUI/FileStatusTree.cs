using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using GitCommands;

namespace GitUI
{
    public partial class FileStatusTree : GitExtensionsControl
    {
        private readonly IndexWatcher _indexWatcher = new IndexWatcher();
        
        public bool IsFolderFirst = true;

        private class NodeTag
        {
            public NodeTag()
            {
                GitItem = null;
                IsPopulated = false;
            }
            public NodeTag(IGitItem aItem)
            {
                GitItem = aItem;
                IsPopulated = false;
            }

            public IGitItem GitItem;
            public bool IsPopulated;
        }

        public FileStatusTree()
        {
            InitializeComponent();
            Translate();
            _indexWatcher.Changed += new IndexWatcher.ChangeEventHandler(IndexWatcher_onIndexChanged);
            BuildTree();
        }

        private void IndexWatcher_onIndexChanged()
        {
            // TOOD: If our tree SHA changes, we'll need to rebuild the entire tree.
        }

        private void UpdateStatus()
        {

        }

        private void BuildTree()
        {
            TreeNode root = treeView.Nodes.Add("HEAD");
            root.Tag = new NodeTag();
            root.Nodes.Add(new TreeNode());
            root.Expand();
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            NodeTag tag = e.Node.Tag as NodeTag;
            if (tag.IsPopulated)
            {
                return;
            }
            treeView.SuspendLayout();

            tag.IsPopulated = true;
            e.Node.Nodes.Clear();

            List<IGitItem> items;
            if (tag.GitItem == null)
            {
                items = GitCommands.GitCommands.GetTree("HEAD");
            }
            else
            {
                items = tag.GitItem.SubItems;
            }

            int folderIndex = 0;
            foreach (IGitItem gitNode in items)
            {
                TreeNode treeNode = new TreeNode(gitNode.Name);
                treeNode.Tag = new NodeTag(gitNode);

                GitItem gitItem = gitNode as GitItem;
                bool isFolder = gitItem == null || gitItem.ItemType == "tree" || gitItem.ItemType == "commit";
                if (isFolder)
                {   
                    treeNode.Nodes.Add(new TreeNode());
                    isFolder = true;
                }

                if (IsFolderFirst && isFolder)
                {
                    e.Node.Nodes.Insert(folderIndex, treeNode);
                    folderIndex++;
                }
                else
                {
                    e.Node.Nodes.Add(treeNode);
                }
            }            

            treeView.ResumeLayout();
        }
    }
}
