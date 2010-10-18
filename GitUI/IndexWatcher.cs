using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using GitCommands;

namespace GitUI
{
    public class IndexWatcher
    {
        public delegate void ChangeEventHandler();
        public ChangeEventHandler Changed;

        public IndexWatcher()
        {
            if (GitIndexWatcher == null)
            {
                GitIndexWatcher = new FileSystemWatcher();
                RefsWatcher = new FileSystemWatcher();
                SetFileSystemWatcher();
            }

            Settings.WorkingDirChanged += new Settings.WorkingDirChangedHandler(Settings_WorkingDirChanged);

            IndexChanged = true;
            GitIndexWatcher.Changed += new FileSystemEventHandler(fileSystemWatcher_Changed);
            RefsWatcher.Changed += new FileSystemEventHandler(fileSystemWatcher_Changed);
        }

        void Settings_WorkingDirChanged(string oldDir, string newDir)
        {
            SetFileSystemWatcher();
        }

        private void SetFileSystemWatcher()
        {
            if (!string.IsNullOrEmpty(GitCommands.Settings.WorkingDirGitDir()))
            {
                try
                {
                    enabled = GitCommands.Settings.UseFastChecks;

                    Path = GitCommands.Settings.WorkingDirGitDir();

                    GitIndexWatcher.Path = GitCommands.Settings.WorkingDirGitDir();
                    GitIndexWatcher.Filter = "index";
                    GitIndexWatcher.IncludeSubdirectories = false;
                    GitIndexWatcher.EnableRaisingEvents = enabled;

                    RefsWatcher.Path = GitCommands.Settings.WorkingDirGitDir() + "\\refs";
                    RefsWatcher.IncludeSubdirectories = true;
                    RefsWatcher.EnableRaisingEvents = enabled;
                }
                catch
                {
                    enabled = false;
                }
            }
        }

        private bool indexChanged;
        public bool IndexChanged 
        { 
            get
            {
                if (!enabled)
                    return true;

                if (Path != GitCommands.Settings.WorkingDirGitDir())
                    return true;

                return indexChanged;
            }
            set
            {
                indexChanged = value;
                GitIndexWatcher.EnableRaisingEvents = !IndexChanged;
            }
        }

        static private bool enabled;
        static private string Path;
        static private FileSystemWatcher GitIndexWatcher { get; set; }
        static private FileSystemWatcher RefsWatcher { get; set; }

        void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            IndexChanged = true;
            Changed();
        }

        public void Reset()
        {
            IndexChanged = false;
        }

        public void Clear()
        {
            IndexChanged = true;
            Changed();
        }
    }
}
