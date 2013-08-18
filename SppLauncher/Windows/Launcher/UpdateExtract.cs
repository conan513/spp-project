using Ionic.Zip;

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
            catch
            {
                return false;
            }

        }
    }
}
