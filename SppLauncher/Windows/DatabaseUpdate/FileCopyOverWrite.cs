using System;
using System.IO;
using System.Windows.Forms;

namespace SppLauncher.Windows.WowAccountCreator
{
    public class FileCopyOverWrite
    {
        public bool Copy(string sourceD, string destD, bool copySubD)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceD);
                DirectoryInfo[] dirs = dir.GetDirectories();

                if (!Directory.Exists(destD) && destD != "")
                {
                    Directory.CreateDirectory(destD);
                }

                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destD, file.Name);
                    file.CopyTo(temppath, true);
                }

                if (copySubD)
                {
                    foreach (DirectoryInfo subdir in dirs)
                    {
                        string temppath = Path.Combine(destD, subdir.Name);
                        Copy(subdir.FullName, temppath, copySubD);
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
