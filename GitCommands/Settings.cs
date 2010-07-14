﻿using System;
using System.Collections.Generic;

using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace GitCommands
{
    public static class Settings
    {
        public static string GitExtensionsVersionString = "1.95";
        public static int GitExtensionsVersionInt = 195;

        private static string translation = "";
        public static string Translation
        {
            get
            {
                return translation;
            }
            set
            {
                translation = value;
            }
        }

        private static bool userProfileHomeDir = false;
        public static bool UserProfileHomeDir
        {
            get
            {
                return userProfileHomeDir;
            }
            set
            {
                userProfileHomeDir = value;
            }
        }


        private static string customHomeDir = "";
        public static string CustomHomeDir
        {
            get
            {
                return customHomeDir;
            }
            set
            {
                customHomeDir = value;
            }
        }

        private static string iconColor = "default";
        public static string IconColor
        {
            get
            {
                return iconColor;
            }
            set
            {
                iconColor = value;
            }
        }

        private static int authorImageSize = 80;
        public static int AuthorImageSize
        {
            get
            {
                return authorImageSize;
            }
            set
            {
                authorImageSize = value;
            }
        }

        private static int authorImageCacheDays = 5;
        public static int AuthorImageCacheDays
        {
            get
            {
                return authorImageCacheDays;
            }
            set
            {
                authorImageCacheDays = value;
            }
        }

        private static bool showAuthorGravatar = true;
        public static bool ShowAuthorGravatar
        {
            get
            {
                return showAuthorGravatar;
            }
            set
            {
                showAuthorGravatar = value;
            }
        }

        private static bool closeCommitDialogAfterCommit = false;
        public static bool CloseCommitDialogAfterCommit
        {
            get
            {
                return closeCommitDialogAfterCommit;
            }
            set
            {
                closeCommitDialogAfterCommit = value;
            }
        }

        private static bool followRenamesInFileHistory = true;
        public static bool FollowRenamesInFileHistory
        {
            get
            {
                return followRenamesInFileHistory;
            }
            set
            {
                followRenamesInFileHistory = value;
            }
        }
         

        private static int revisionGraphWidth = 6;
        public static int RevisionGraphWidth
        {
            get
            {
                return revisionGraphWidth;
            }
            set
            {
                revisionGraphWidth = value;
            }
        }

        private static float revisionGraphThickness = 1F;
        public static float RevisionGraphThickness
        {
            get
            {
                return revisionGraphThickness;
            }
            set
            {
                revisionGraphThickness = value;
            }
        }

        #region Colors

        private static Color otherTagColor = Color.Gray;
        public static Color OtherTagColor
        {
            get
            {
                return otherTagColor;
            }
            set
            {
                otherTagColor = value;
            }
        }

        private static Color tagColor = Color.DarkBlue;
        public static Color TagColor
        {
            get
            {
                return tagColor;
            }
            set
            {
                tagColor = value;
            }
        }

        private static Color graphColor = Color.Red;
        public static Color GraphColor
        {
            get
            {
                return graphColor;
            }
            set
            {
                graphColor = value;
            }
        }


        private static Color branchColor = Color.DarkRed;
        public static Color BranchColor
        {
            get
            {
                return branchColor;
            }
            set
            {
                branchColor = value;
            }
        }

        private static Color remoteBranchColor = Color.Green;
        public static Color RemoteBranchColor
        {
            get
            {
                return remoteBranchColor;
            }
            set
            {
                remoteBranchColor = value;
            }
        }

        private static Color diffSection = Color.FromArgb(230, 230, 230);
        public static Color DiffSectionColor
        {
            get
            {
                return diffSection;
            }
            set
            {
                diffSection = value;
            }
        }

        private static Color diffRemoved = Color.FromArgb(255, 200, 200);
        public static Color DiffRemovedColor
        {
            get
            {
                return diffRemoved;
            }
            set
            {
                diffRemoved = value;
            }
        }

        private static Color diffRemovedExtra = Color.FromArgb(255, 150, 150);
        public static Color DiffRemovedExtraColor
        {
            get
            {
                return diffRemovedExtra;
            }
            set
            {
                diffRemovedExtra = value;
            }
        }

        private static Color diffAdded = Color.FromArgb(200, 255, 200);
        public static Color DiffAddedColor
        {
            get
            {
                return diffAdded;
            }
            set
            {
                diffAdded = value;
            }
        }

        private static Color diffAddedExtra = Color.FromArgb(135, 255, 135);
        public static Color DiffAddedExtraColor
        {
            get
            {
                return diffAddedExtra;
            }
            set
            {
                diffAddedExtra = value;
            }
        }

        private static bool multicolorBranches = true;
        public static bool MulticolorBranches
        {
            get
            {
                return multicolorBranches;
            }
            set
            {
                multicolorBranches = value;
            }
        }

        private static bool stripedBanchChange = true;
        public static bool StripedBanchChange
        {
            get
            {
                return stripedBanchChange;
            }
            set
            {
                stripedBanchChange = value;
            }
        }

        private static bool branchBorders = true;
        public static bool BranchBorders
        {
            get
            {
                return branchBorders;
            }
            set
            {
                branchBorders = value;
            }
        }


        #endregion
        private static Encoding encoding = Encoding.UTF8;
        public static Encoding Encoding
        {
            get
            {
                return encoding;
            }
            set
            {
                encoding = value;
            }
        }

        private static string pullMerge = "merge";
        public static string PullMerge
        {
            get
            {
                return pullMerge;
            }
            set
            {
                pullMerge = value;
            }
        }

        private static string smtp = "";
        public static string Smtp
        {
            get
            {
                return smtp;
            }
            set
            {
                smtp = value;
            }
        }

        private static bool autoStash = false;
        public static bool AutoStash
        {
            get
            {
                return autoStash;
            }
            set
            {
                autoStash = value;
            }
        }

        private static bool orderRevisionByDate = true;
        public static bool OrderRevisionByDate
        {
            get
            {
                return orderRevisionByDate;
            }
            set
            {
                orderRevisionByDate = value;
            }
        }

        private static string dictionary = "en-US";
        public static string Dictionary
        {
            get
            {
                return dictionary;
            }
            set
            {
                dictionary = value;
            }
        }

        private static bool showGitCommandLine = false;
        public static bool ShowGitCommandLine
        {
            get
            {
                return showGitCommandLine;
            }
            set
            {
                showGitCommandLine = value;
            }
        }

        private static bool relativeDate = true;
        public static bool RelativeDate
        {
            get
            {
                return relativeDate;
            }
            set
            {
                relativeDate = value;
            }
        }

        private static bool useFastChecks = true;
        public static bool UseFastChecks
        {
            get
            {
                return useFastChecks;
            }
            set
            {
                useFastChecks = value;
            }
        }

        private static bool showRevisionGraph = true;
        public static bool ShowRevisionGraph
        {
            get
            {
                return showRevisionGraph;
            }
            set
            {
                showRevisionGraph = value;
            }
        }

        private static bool showAuthorDate = false;
        public static bool ShowAuthorDate
        {
            get
            {
                return showAuthorDate;
            }
            set
            {
                showAuthorDate = value;
            }
        }

        private static bool closeProcessDialog = false;
        public static bool CloseProcessDialog
        {
            get
            {
                return closeProcessDialog;
            }
            set
            {
                closeProcessDialog = value;
            }
        }

        public static string GetDictionaryDir()
        {
            if (Application.UserAppDataRegistry.GetValue("InstallDir") != null)
                return GetInstallDir() + "\\Dictionaries\\";

            return "";
        }


        public static string GetInstallDir()
        {
            if (Application.UserAppDataRegistry.GetValue("InstallDir") != null)
                return Application.UserAppDataRegistry.GetValue("InstallDir").ToString();

            return "";
        }

        public static void SetInstallDir(string dir)
        {
            Application.UserAppDataRegistry.SetValue("InstallDir", dir);
        }


        private static bool showCurrentBranchOnly = false;
        public static bool ShowCurrentBranchOnly
        {
            get
            {
                return showCurrentBranchOnly;
            }
            set
            {
                showCurrentBranchOnly = value;
            }
        }

        private static bool branchFilterEnabled = false;
        public static bool BranchFilterEnabled
        {
            get
            {
                return branchFilterEnabled;
            }
            set
            {
                branchFilterEnabled = value;
            }
        }

        private static string gitCommand = "git.cmd";
        public static string GitCommand
        {
            get
            {
                return gitCommand;
            }
            set
            {
                gitCommand = value;
            }
        }

        /*
        private static string gitDir = "";
        public static string GitDir
        {
            get
            {
                return gitDir;
            }
            set
            {
                gitDir = value;
                if (gitDir.Length > 0 && gitDir[gitDir.Length - 1] != '\\')
                    gitDir += "\\";
                gitDir = gitDir.Replace("\\\\", "\\");
                gitDir = gitDir.Replace("//", "/");

            }
        }*/

        private static string gitBinDir = "";
        public static string GitBinDir
        {
            get
            {
                return gitBinDir;
            }
            set
            {
                gitBinDir = value;
                if (gitBinDir.Length > 0 && gitBinDir[gitBinDir.Length - 1] != '\\')
                    gitBinDir += "\\";

                if (!string.IsNullOrEmpty(gitBinDir))
                    Environment.SetEnvironmentVariable("path", Environment.GetEnvironmentVariable("path", EnvironmentVariableTarget.Process) + ";" + gitBinDir, EnvironmentVariableTarget.Process);

            }
        }

        private static int maxCommits = 2000;
        public static int MaxCommits
        {
            get
            {
                return maxCommits;
            }
            set
            {
                maxCommits = value;
            }
        }

        public static bool ValidWorkingDir()
        {
            return ValidWorkingDir(WorkingDir);
        }

        public static bool ValidWorkingDir(string dir)
        {
            if (string.IsNullOrEmpty(dir))
                return false;

            if (Directory.Exists(dir + "\\" + ".git"))
                return true;

            if (!dir.Contains(".git") &&
                Directory.Exists(dir + "\\" + "info") &&
                Directory.Exists(dir + "\\" + "objects") &&
                Directory.Exists(dir + "\\" + "refs")
                )
                return true;

            return false;
        }

        public static bool IsBareRepository()
        {
            if (Directory.Exists(WorkingDir + "\\" + ".git"))
                return false;

            return true;
        }

        public static string WorkingDirGitDir()
        {
            string workingDir = WorkingDir;

            if (Directory.Exists(workingDir + ".git"))
                return workingDir + ".git";

            if (Directory.Exists(workingDir + "\\" + ".git"))
                return workingDir + "\\" + ".git";

            return WorkingDir;
        }


        private static string workingdir;
        public static string WorkingDir
        {
            get
            {
                return workingdir;
            }
            set
            {
                workingdir = GitCommands.FindGitWorkingDir(value.Trim());
            }
        }

        private static readonly CommandLogger _gitLog = new CommandLogger();
        public static CommandLogger GitLog
        {
            get
            {
                return _gitLog;
            }
        }

        private static string plink = "";
        public static string Plink
        {
            get
            {
                return plink;
            }
            set
            {
                plink = value;
            }
        }

        private static string puttygen = "";
        public static string Puttygen
        {
            get
            {
                return puttygen;
            }
            set
            {
                puttygen = value;
            }
        }

        private static string pageant = "";
        public static string Pageant
        {
            get
            {
                return pageant;
            }
            set
            {
                pageant = value;
            }
        }

        private static bool autoStartPageant = true;
        public static bool AutoStartPageant
        {
            get
            {
                return autoStartPageant;
            }
            set
            {
                autoStartPageant = value;
            }
        }


        public static void SaveSettings()
        {
            try
            {
                if (Settings.Encoding.GetType() == typeof(ASCIIEncoding))
                    Application.UserAppDataRegistry.SetValue("encoding", "ASCII");
                else
                    if (Settings.Encoding.GetType() == typeof(UnicodeEncoding))
                        Application.UserAppDataRegistry.SetValue("encoding", "Unicode");
                    else
                        if (Settings.Encoding.GetType() == typeof(UTF7Encoding))
                            Application.UserAppDataRegistry.SetValue("encoding", "UTF7");
                        else
                            if (Settings.Encoding.GetType() == typeof(UTF8Encoding))
                                Application.UserAppDataRegistry.SetValue("encoding", "UTF8");
                            else
                                if (Settings.Encoding.GetType() == typeof(UTF32Encoding))
                                    Application.UserAppDataRegistry.SetValue("encoding", "UTF32");
                                else
                                    if (Settings.Encoding == System.Text.Encoding.Default)
                                        Application.UserAppDataRegistry.SetValue("encoding", "Default");



                Application.UserAppDataRegistry.SetValue("history", Repositories.SerializeHistory());
                Application.UserAppDataRegistry.SetValue("repositories", Repositories.SerializeRepositories());

                Application.UserAppDataRegistry.SetValue("showauthorgravatar", Settings.showAuthorGravatar);

                Application.UserAppDataRegistry.SetValue("userprofilehomedir", Settings.UserProfileHomeDir);
                Application.UserAppDataRegistry.SetValue("customhomedir", Settings.CustomHomeDir);

                Application.UserAppDataRegistry.SetValue("closeCommitDialogAfterCommit", Settings.CloseCommitDialogAfterCommit);
                Application.UserAppDataRegistry.SetValue("markIllFormedLinesInCommitMsg", Settings.MarkIllFormedLinesInCommitMsg);

                Application.UserAppDataRegistry.SetValue("diffaddedcolor", System.Drawing.ColorTranslator.ToHtml(Settings.DiffAddedColor));
                Application.UserAppDataRegistry.SetValue("diffremovedcolor", System.Drawing.ColorTranslator.ToHtml(Settings.DiffRemovedColor));
                Application.UserAppDataRegistry.SetValue("diffaddedextracolor", System.Drawing.ColorTranslator.ToHtml(Settings.DiffAddedExtraColor));
                Application.UserAppDataRegistry.SetValue("diffremovedextracolor", System.Drawing.ColorTranslator.ToHtml(Settings.DiffRemovedExtraColor));
                Application.UserAppDataRegistry.SetValue("diffsectioncolor", System.Drawing.ColorTranslator.ToHtml(Settings.DiffSectionColor));
                Application.UserAppDataRegistry.SetValue("multicolorbranches", Settings.MulticolorBranches);
                Application.UserAppDataRegistry.SetValue("branchborders", Settings.BranchBorders);
                Application.UserAppDataRegistry.SetValue("stripedbanchchange", Settings.StripedBanchChange);
                Application.UserAppDataRegistry.SetValue("tagcolor", System.Drawing.ColorTranslator.ToHtml(Settings.TagColor));
                Application.UserAppDataRegistry.SetValue("graphcolor", System.Drawing.ColorTranslator.ToHtml(Settings.GraphColor));
                Application.UserAppDataRegistry.SetValue("branchcolor", System.Drawing.ColorTranslator.ToHtml(Settings.BranchColor));
                Application.UserAppDataRegistry.SetValue("remotebranchcolor", System.Drawing.ColorTranslator.ToHtml(Settings.RemoteBranchColor));
                Application.UserAppDataRegistry.SetValue("othertagcolor", System.Drawing.ColorTranslator.ToHtml(Settings.OtherTagColor));

                Application.UserAppDataRegistry.SetValue("iconcolor", Settings.IconColor);
                
                Application.UserAppDataRegistry.SetValue("translation", Settings.Translation);
                Application.UserAppDataRegistry.SetValue("authorImageCacheDays", Settings.AuthorImageCacheDays);
                Application.UserAppDataRegistry.SetValue("authorimagesize", Settings.AuthorImageSize);

                Application.UserAppDataRegistry.SetValue("maxcommits", Settings.MaxCommits);
                Application.UserAppDataRegistry.SetValue("gitdir", Settings.GitCommand);
                Application.UserAppDataRegistry.SetValue("gitbindir", Settings.GitBinDir);
                Application.UserAppDataRegistry.SetValue("showallbranches", Settings.ShowCurrentBranchOnly);
                Application.UserAppDataRegistry.SetValue("branchfilterenabled", Settings.BranchFilterEnabled);
                Application.UserAppDataRegistry.SetValue("closeprocessdialog", Settings.CloseProcessDialog);
                Application.UserAppDataRegistry.SetValue("showrevisiongraph", Settings.ShowRevisionGraph);
                Application.UserAppDataRegistry.SetValue("showauthordate", Settings.ShowAuthorDate);
                Application.UserAppDataRegistry.SetValue("orderrevisiongraphbydate", Settings.OrderRevisionByDate);

                Application.UserAppDataRegistry.SetValue("showgitcommandline", Settings.ShowGitCommandLine);
                Application.UserAppDataRegistry.SetValue("usefastchecks", Settings.UseFastChecks);
                Application.UserAppDataRegistry.SetValue("relativedate", Settings.RelativeDate);

                Application.UserAppDataRegistry.SetValue("gitssh", GitCommands.GetSsh());
                Application.UserAppDataRegistry.SetValue("pullmerge", Settings.PullMerge);

                Application.UserAppDataRegistry.SetValue("autostash", Settings.AutoStash);
                Application.UserAppDataRegistry.SetValue("followrenamesinfilehistory", Settings.FollowRenamesInFileHistory);

                Application.UserAppDataRegistry.SetValue("plink", Settings.Plink);
                Application.UserAppDataRegistry.SetValue("puttygen", Settings.Puttygen);
                Application.UserAppDataRegistry.SetValue("pageant", Settings.Pageant);

                Application.UserAppDataRegistry.SetValue("smtp", Settings.Smtp);

                Application.UserAppDataRegistry.SetValue("dictionary", Settings.Dictionary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load settings.\n\n" + ex.Message);
            }
        }

        public static void LoadSettings()
        {
            try
            {
                if (Application.UserAppDataRegistry.GetValue("maxcommits") != null)
                {
                    int result;
                    if (int.TryParse(Application.UserAppDataRegistry.GetValue("maxcommits").ToString(), out result) == true)
                    {
                        Settings.MaxCommits = result;
                    }
                }

                if (Application.UserAppDataRegistry.GetValue("authorImageCacheDays") != null)
                {
                    int result;
                    if (int.TryParse(Application.UserAppDataRegistry.GetValue("authorImageCacheDays").ToString(), out result) == true)
                    {
                        Settings.AuthorImageCacheDays = result;
                    }
                }


                if (Application.UserAppDataRegistry.GetValue("authorimagesize") != null)
                {
                    int result;
                    if (int.TryParse(Application.UserAppDataRegistry.GetValue("authorimagesize").ToString(), out result) == true)
                    {
                        Settings.AuthorImageSize = result;
                    }
                }

                string encoding = null;
                if (Application.UserAppDataRegistry.GetValue("encoding") != null) encoding = Application.UserAppDataRegistry.GetValue("encoding").ToString();

                if (string.IsNullOrEmpty(encoding))
                    Settings.Encoding = new UTF8Encoding(false);
                else
                    if (encoding.Equals("Default", StringComparison.CurrentCultureIgnoreCase))
                        Settings.Encoding = System.Text.Encoding.Default;
                    else
                        if (encoding.Equals("Unicode", StringComparison.CurrentCultureIgnoreCase))
                            Settings.Encoding = new UnicodeEncoding();
                        else
                            if (encoding.Equals("ASCII", StringComparison.CurrentCultureIgnoreCase))
                                Settings.Encoding = new ASCIIEncoding();
                            else
                                if (encoding.Equals("UTF7", StringComparison.CurrentCultureIgnoreCase))
                                    Settings.Encoding = new UTF7Encoding();
                                else
                                    if (encoding.Equals("UTF32", StringComparison.CurrentCultureIgnoreCase))
                                        Settings.Encoding = new UTF32Encoding(true, false);
                                    else
                                        Settings.Encoding = new UTF8Encoding(false);

                try
                {
                    if (Application.UserAppDataRegistry.GetValue("diffaddedcolor") != null) Settings.DiffAddedColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("diffaddedcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("diffremovedcolor") != null) Settings.DiffRemovedColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("diffremovedcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("diffaddedextracolor") != null) Settings.DiffAddedExtraColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("diffaddedextracolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("diffremovedextracolor") != null) Settings.DiffRemovedExtraColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("diffremovedextracolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("diffsectioncolor") != null) Settings.DiffSectionColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("diffsectioncolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("tagcolor") != null) Settings.TagColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("tagcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("graphcolor") != null) Settings.GraphColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("graphcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("branchcolor") != null) Settings.BranchColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("branchcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("remotebranchcolor") != null) Settings.RemoteBranchColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("remotebranchcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("othertagcolor") != null) Settings.OtherTagColor = System.Drawing.ColorTranslator.FromHtml(Application.UserAppDataRegistry.GetValue("othertagcolor").ToString());
                    if (Application.UserAppDataRegistry.GetValue("multicolorbranches") != null) Settings.MulticolorBranches = Application.UserAppDataRegistry.GetValue("multicolorbranches").ToString() == "True";
                    if (Application.UserAppDataRegistry.GetValue("branchborders") != null) Settings.BranchBorders = Application.UserAppDataRegistry.GetValue("branchborders").ToString() == "True";
                    if (Application.UserAppDataRegistry.GetValue("stripedbanchchange") != null) Settings.StripedBanchChange = Application.UserAppDataRegistry.GetValue("stripedbanchchange").ToString() == "True";
                    
                }
                catch
                {
                }

                if (Application.UserAppDataRegistry.GetValue("translation") != null) Settings.Translation = Application.UserAppDataRegistry.GetValue("translation").ToString();
                if (Application.UserAppDataRegistry.GetValue("pullmerge") != null) Settings.PullMerge = Application.UserAppDataRegistry.GetValue("pullmerge").ToString();
                if (Application.UserAppDataRegistry.GetValue("gitssh") != null) GitCommands.SetSsh(Application.UserAppDataRegistry.GetValue("gitssh").ToString());
                if (Application.UserAppDataRegistry.GetValue("plink") != null) Settings.Plink = Application.UserAppDataRegistry.GetValue("plink").ToString();
                if (Application.UserAppDataRegistry.GetValue("puttygen") != null) Settings.Puttygen = Application.UserAppDataRegistry.GetValue("puttygen").ToString();
                if (Application.UserAppDataRegistry.GetValue("pageant") != null) Settings.Pageant = Application.UserAppDataRegistry.GetValue("pageant").ToString();

                if (Application.UserAppDataRegistry.GetValue("dictionary") != null) Settings.Dictionary = Application.UserAppDataRegistry.GetValue("dictionary").ToString();
                if (Application.UserAppDataRegistry.GetValue("smtp") != null) Settings.Smtp = Application.UserAppDataRegistry.GetValue("smtp").ToString();

                if (Application.UserAppDataRegistry.GetValue("showauthorgravatar") != null) Settings.showAuthorGravatar = Application.UserAppDataRegistry.GetValue("showauthorgravatar").ToString() == "True";

                if (Application.UserAppDataRegistry.GetValue("userprofilehomedir") != null) Settings.UserProfileHomeDir = Application.UserAppDataRegistry.GetValue("userprofilehomedir").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("customhomedir") != null) Settings.CustomHomeDir = Application.UserAppDataRegistry.GetValue("customhomedir").ToString();
                
                if (Application.UserAppDataRegistry.GetValue("closeCommitDialogAfterCommit") != null) Settings.CloseCommitDialogAfterCommit = Application.UserAppDataRegistry.GetValue("closeCommitDialogAfterCommit").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("markIllFormedLinesInCommitMsg") != null) Settings.MarkIllFormedLinesInCommitMsg = Application.UserAppDataRegistry.GetValue("markIllFormedLinesInCommitMsg").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("followrenamesinfilehistory") != null) Settings.FollowRenamesInFileHistory = Application.UserAppDataRegistry.GetValue("followrenamesinfilehistory").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("autostash") != null) Settings.AutoStash = Application.UserAppDataRegistry.GetValue("autostash").ToString() == "True";

                if (Application.UserAppDataRegistry.GetValue("iconcolor") != null) Settings.IconColor = Application.UserAppDataRegistry.GetValue("iconcolor").ToString();
                if (Application.UserAppDataRegistry.GetValue("relativedate") != null) Settings.RelativeDate = Application.UserAppDataRegistry.GetValue("relativedate").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("usefastchecks") != null) Settings.UseFastChecks = Application.UserAppDataRegistry.GetValue("usefastchecks").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("showgitcommandline") != null) Settings.ShowGitCommandLine = Application.UserAppDataRegistry.GetValue("showgitcommandline").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("showrevisiongraph") != null) Settings.ShowRevisionGraph = Application.UserAppDataRegistry.GetValue("showrevisiongraph").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("showauthordate") != null) Settings.ShowAuthorDate = Application.UserAppDataRegistry.GetValue("showauthordate").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("closeprocessdialog") != null) Settings.CloseProcessDialog = Application.UserAppDataRegistry.GetValue("closeprocessdialog").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("showallbranches") != null) Settings.ShowCurrentBranchOnly = Application.UserAppDataRegistry.GetValue("showallbranches").ToString() == "False";
                if (Application.UserAppDataRegistry.GetValue("branchfilterenabled") != null) Settings.BranchFilterEnabled = Application.UserAppDataRegistry.GetValue("branchfilterenabled").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("orderrevisiongraphbydate") != null) Settings.OrderRevisionByDate = Application.UserAppDataRegistry.GetValue("orderrevisiongraphbydate").ToString() == "True";
                if (Application.UserAppDataRegistry.GetValue("gitdir") != null) Settings.GitCommand = Application.UserAppDataRegistry.GetValue("gitdir").ToString();
                if (Application.UserAppDataRegistry.GetValue("gitbindir") != null) Settings.GitBinDir = Application.UserAppDataRegistry.GetValue("gitbindir").ToString();

                if (Application.UserAppDataRegistry.GetValue("history") != null) Repositories.DeserializeHistory(Application.UserAppDataRegistry.GetValue("history").ToString());
                if (Application.UserAppDataRegistry.GetValue("repositories") != null) Repositories.DeserializeRepositories(Application.UserAppDataRegistry.GetValue("repositories").ToString());
            }
            catch
            {
            }
        }

        public static bool MarkIllFormedLinesInCommitMsg { get; set; }
    }
}
