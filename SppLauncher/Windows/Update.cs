using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        readonly Stopwatch sw = new Stopwatch();

        private void Update_Shown(object sender, EventArgs e)
        {
            bw_updater.RunWorkerAsync();
        }

        private void DownloadUpdate(string URL, string Save)
        {
            lbl_status.Text = "Status: Connecting";
            Thread.Sleep(100);
            string exePath = AppDomain.CurrentDomain.FriendlyName;

            if (File.Exists("SppLauncher_OLD.exe"))
            {
                File.Delete("SppLauncher_OLD.exe");
            }

            File.Move(exePath, @"SppLauncher_OLD.exe");
            File.SetAttributes("SppLauncher_OLD.exe", FileAttributes.Hidden);

            var client                      = new WebClient();
            client.DownloadProgressChanged += client_DownloadProgressChanged;
            client.DownloadFileCompleted   += client_DownloadFileCompleted;
            lbl_status.Text                 = "Status: Downloading";
            client.DownloadFileAsync(
                new Uri(URL), Save);
            sw.Start();
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn    = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            lbl_downByte.Text = e.BytesReceived / 1024 + " / " + e.TotalBytesToReceive / 1024 + " Kb";
            lbl_speed.Text    = "Speed: " + (bytesIn / 1024 / sw.Elapsed.TotalSeconds).ToString("0.00") + " Kb/s";
            pb_down.Value     = int.Parse(Math.Truncate(percentage).ToString(CultureInfo.InvariantCulture));
            lbl_Perecent.Text = int.Parse(Math.Truncate(percentage).ToString(CultureInfo.InvariantCulture)) + "%";
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_status.Text = "Status: Completed";
            Thread.Sleep(500);
            Process.Start("SppLauncher.exe");
            Application.Exit();
        }

        private void bw_updater_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadUpdate("http://dl.dropbox.com/u/7587303/Updates/SppLauncher.exe", "SppLauncher.exe");
        }
    }
}

