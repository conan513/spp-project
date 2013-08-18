using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SppLauncher.Windows.BugReport
{
    class GetServerIP
    {

        public string Getip()
        {
            try
            {
                var client = new WebClient();
                Stream stream = client.OpenRead("http://dl.dropbox.com/u/7587303/Updates/ip.txt");
                var reader = new StreamReader(stream);
                string ip = reader.ReadToEnd();
                return ip != "" ? ip : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
