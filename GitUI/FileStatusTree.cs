using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GitUI
{
    public partial class FileStatusTree : GitExtensionsControl
    {
        private readonly IndexWatcher _indexWatcher = new IndexWatcher();

        public FileStatusTree()
        {
            InitializeComponent();
            Translate();
            _indexWatcher.Changed += new IndexWatcher.ChangeEventHandler(IndexWatcher_onIndexChanged);
        }

        private void IndexWatcher_onIndexChanged()
        {
        }
    }
}
