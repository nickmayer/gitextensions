﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GitCommands;

namespace GitUI
{
    public partial class FormRevisionFilter : GitExtensionsForm
    {
        public FormRevisionFilter()
        {
            InitializeComponent(); Translate();
        }

        private void FormRevisionFilter_Load(object sender, EventArgs e)
        {
            EnableFilters();
        }

        private void SinceCheck_CheckedChanged(object sender, EventArgs e)
        {
            EnableFilters();
        }

        private void OnBranchFilterCheckedChanged(object sender, EventArgs e)
        {
            Settings.BranchFilterEnabled = BranchFilterCheck.Checked;
            EnableFilters();
        }

        private void OnShowCurrentBranchOnlyCheckedChanged(object sender, EventArgs e)
        {
            Settings.ShowCurrentBranchOnly = CurrentBranchOnlyCheck.Checked;
            EnableFilters();
        }

        private void EnableFilters()
        {
            Since.Enabled = SinceCheck.Checked;
            Until.Enabled = CheckUntil.Checked;
            Author.Enabled = AuthorCheck.Checked;
            Committer.Enabled = CommitterCheck.Checked;
            Message.Enabled = MessageCheck.Checked;
            _Limit.Enabled = LimitCheck.Checked;
            FileFilter.Enabled = FileFilterCheck.Checked;

            BranchFilterCheck.Checked = Settings.BranchFilterEnabled;
            CurrentBranchOnlyCheck.Checked = Settings.ShowCurrentBranchOnly;

            CurrentBranchOnlyCheck.Enabled = BranchFilterCheck.Checked;
            BranchFilter.Enabled = BranchFilterCheck.Checked &&
                                   !CurrentBranchOnlyCheck.Checked;
        }

        public string GetFilter()
        {
            string filter = "";
            if (SinceCheck.Checked)
                filter += " --since=\"" + Since.Value.ToString() + "\"";
            if (CheckUntil.Checked)
                filter += " --until=\"" + Until.Value.ToString() + "\"";
            if (AuthorCheck.Checked)
                filter += " --author=\"" + Author.Text + "\"";
            if (CommitterCheck.Checked)
                filter += " --committer=\"" + Committer.Text + "\"";
            if (MessageCheck.Checked)
                filter += " --grep=\"" + Message.Text + "\"";
            if (LimitCheck.Checked)
                filter += " --max-count=\"" + _Limit.Value.ToString("N") + "\"";
            if (!string.IsNullOrEmpty(filter) && IgnoreCase.Checked)
                filter += " --regexp-ignore-case";
            if (FileFilterCheck.Checked)
                filter += " -- \"" + FileFilter.Text.Replace('\\', '/') + "\"";

            return filter;
        }

        public string GetBranchFilter()
        {
            if (!Settings.BranchFilterEnabled || Settings.ShowCurrentBranchOnly)
                return String.Empty;

            return BranchFilter.Text;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
