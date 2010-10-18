using System;
using System.ComponentModel;
using ResourceManager.Translation;

namespace GitUI
{
    public partial class FormMain : GitExtensionsForm
    {
        public FormMain()
        {
            InitializeComponent();
            Translate();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RestorePosition("browse");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
