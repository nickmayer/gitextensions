﻿using System;
using System.Windows.Forms;
using GitUI;
using System.IO;
using GitCommands;

namespace GitExtensions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] args = Environment.GetCommandLineArgs();
            {
                FormSplash formSplash = new FormSplash();
                formSplash.Show();
                formSplash.SetAction("Load settings");
                GitCommands.Settings.LoadSettings();
                //Quick HOME check:
                formSplash.SetAction("Check home path");
                FormFixHome.CheckHomePath();
                //Register plugins
                formSplash.SetAction("Load plugins");
                PluginLoader.Load();

                try
                {
                    if (Application.UserAppDataRegistry == null ||
                        Application.UserAppDataRegistry.GetValue("checksettings") == null ||
                        Application.UserAppDataRegistry.GetValue("checksettings").ToString() == "true")
                    {
                        formSplash.SetAction("Check settings");
                        var settings = new FormSettings();
                        if (!settings.CheckSettings())
                        {
                            FormSettings.AutoSolveAllSettings();
                            //Application.Run();
                            GitUICommands.Instance.StartSettingsDialog();
                        }
                    }
                }
                catch
                {
                }

                formSplash.Close();
            }

            if (args.Length >= 3)
            {
                if (Directory.Exists(args[2]))
                    GitCommands.Settings.WorkingDir = args[2];

                if (string.IsNullOrEmpty(GitCommands.Settings.WorkingDir))
                {
                    if (args[2].Contains("\\"))
                        GitCommands.Settings.WorkingDir = args[2].Substring(0, args[2].LastIndexOf('\\'));
                }

                if (GitCommands.Settings.ValidWorkingDir())
                    Repositories.RepositoryHistory.AddMostRecentRepository(GitCommands.Settings.WorkingDir);
            }

            if (string.IsNullOrEmpty(GitCommands.Settings.WorkingDir))
                GitCommands.Settings.WorkingDir = Directory.GetCurrentDirectory();

            if (args.Length <= 1)
            {
                ////Application.Run();
                GitUICommands.Instance.StartBrowseDialog();
                return;
            }
            // if we are here args.Length > 1
            runCommand(args);

            GitCommands.Settings.SaveSettings();
        }

        private static void runCommand(string[] args)
        {
            if (args[1] == "mergeconflicts")
            {
                //Application.Run();
                GitUICommands.Instance.StartResolveConflictsDialog();
                return;
            }
            if (args[1] == "gitbash")
            {
                GitCommands.GitCommands.RunBash();
                return;
            }
            if (args[1] == "gitignore")
            {
                //Application.Run();
                GitUICommands.Instance.StartEditGitIgnoreDialog();
                return;
            }
            if (args[1] == "remotes")
            {
                //Application.Run();
                GitUICommands.Instance.StartRemotesDialog();
                return;
            }
            if (args[1] == "browse")
            {
                                    string filter = "";
                                    if (args.Length > 2 && args[2].StartsWith("-filter="))
                                    {
                                        filter = args[2].Replace("-filter=", "");
                                    }
                                    GitUICommands.Instance.StartBrowseDialog(filter);
            }
            if (args[1] == "addfiles" || args[1] == "add")
            {
                //Application.Run();
                GitUICommands.Instance.StartAddFilesDialog();
                return;

            }
            if (args[1] == "applypatch" || args[1] == "apply")
            {
                //Application.Run();
                GitUICommands.Instance.StartApplyPatchDialog();
                return;
            }
            if (args[1] == "branch")
            {
                //Application.Run();
                GitUICommands.Instance.StartCreateBranchDialog();
                return;
            }
            if (args[1] == "checkoutbranch" || args[1] == "checkout")
            {
                //Application.Run();
                GitUICommands.Instance.StartCheckoutBranchDialog();
                return;
            }
            if (args[1] == "checkoutrevision")
            {
                //Application.Run();
                GitUICommands.Instance.StartCheckoutRevisionDialog();
                return;
            }
            if (args[1] == "init")
            {
                //Application.Run();
                if (args.Length > 2)
                    GitUICommands.Instance.StartInitializeDialog(args[2]);
                else
                    GitUICommands.Instance.StartInitializeDialog();
                return;
            }
            if (args[1] == "clone")
            {
                //Application.Run();
                GitUICommands.Instance.StartCloneDialog();
                return;
            }
            if (args[1] == "commit")
            {
                //Application.Run();
                GitUICommands.Instance.StartCommitDialog();
                return;
            }
            if (args[1] == "filehistory")
            {
                if (args.Length > 2)
                {
                    //Remove working dir from filename. This is to prevent filenames that are too
                    //long while there is room left when the workingdir was not in the path.
                    string fileName = args[2].Replace(Settings.WorkingDir, "").Replace('\\', '/');

                    //Application.Run();
                    GitUICommands.Instance.StartFileHistoryDialog(fileName);

                }
                else
                    MessageBox.Show("Cannot open hile history, there is no file selected.", "File history");
                return;
            }
            if (args[1] == "formatpatch")
            {
                //Application.Run();
                GitUICommands.Instance.StartFormatPatchDialog();
                return;
            }
            if (args[1] == "pull")
            {
                //Application.Run();
                GitUICommands.Instance.StartPullDialog();
                return;
            }
            if (args[1] == "push")
            {
                //Application.Run();
                GitUICommands.Instance.StartPushDialog();
                return;
            }
            if (args[1] == "settings")
            {
                //Application.Run();
                GitUICommands.Instance.StartSettingsDialog();
                return;
            }
            if (args[1] == "viewdiff")
            {
                //Application.Run();
                GitUICommands.Instance.StartCompareRevisionsDialog();
                return;
            }
            if (args[1] == "rebase")
            {
                //Application.Run();
                GitUICommands.Instance.StartRebaseDialog(null);
                return;
            }

            if (args[1] == "merge")
            {
                //Application.Run();
                GitUICommands.Instance.StartMergeBranchDialog(null);
                return;
            }

            if (args[1] == "cherry")
            {
                //Application.Run();
                GitUICommands.Instance.StartCherryPickDialog();
                return;
            }

            if (args[1] == "revert")
            {
                Application.Run(new FormRevert(args[2]));
                return;
            }

            if (args[1] == "tag")
            {
                //Application.Run();
                GitUICommands.Instance.StartCreateTagDialog();
                return;
            }
            if (args[1] == "about")
            {
                Application.Run(new AboutBox());
                return;
            }
            if (args[1] == "stash")
            {
                //Application.Run();
                GitUICommands.Instance.StartStashDialog();
                return;
            }

            Application.Run(new FormCommandlineHelp());
        }
    }
}
