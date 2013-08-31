using System;
using System.Windows.Forms;
using Ionic.Zip;
using SppLauncher.Windows.Launcher;

namespace SppLauncher.Class
{
    class UpdateExtract
    {
        public bool Extract()
        {
            try
            {
                string unpck = Launcher.UpdateUnpack;
                string unpckDir = @"update";
                using (ZipFile zip = ZipFile.Read(unpck))
                {
                    foreach (ZipEntry e in zip)
                    {
                        e.Password = "89765487";
                        e.Extract(unpckDir, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some exception: mysql\n" + ex.Message);
                return false;
            }

        }
    }
}
