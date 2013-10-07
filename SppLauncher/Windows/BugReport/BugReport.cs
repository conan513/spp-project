using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SppLauncher.Properties;

namespace SppLauncher.Windows.BugReport
{
    public partial class BugReport : Form
    {
        private readonly int count = Environment.ProcessorCount;
        public static string RemoteIp;
        private readonly GetSysInfo getSys;
        private readonly SendReport send;
        private readonly GetServerIP ip;

        public BugReport()
        {
            InitializeComponent();
            getSys = new GetSysInfo();
            send = new SendReport();
            ip = new GetServerIP();
            cbBugType.Text = "PlayerBots";
            
            bwGetSysInfo.RunWorkerAsync();
        }

          //! send.SendError("report", txbMail.Text, cbBugType.Text, txbDesc.Text, getSys.GetProcessorName(), count.ToString(), getSys.getmemory().ToString(),
          //! getSys.getOS(), "Prog: " + Launcher.Launcher.CurrProgVer + "," + " Emu: " + Launcher.Launcher.CurrEmuVer);

        public void test()
        {
            var cpu = getSys.GetProcessorName().Split(';');
            PostData("http://login.splights.eu/index.php?",
                "action=bugreport&bugtype=" + cbBugType.Text + "&email="+ txbMail.Text +"&description="+ txbDesc.Text +"&cpuname="+ cpu[0]
                +"&cpucore="+ cpu[1] +"&ram="+ getSys.getmemory() +"&os="+ getSys.getOS() +"&ver=" + Launcher.Launcher.CurrProgVer + " " + Launcher.Launcher.CurrEmuVer);
        }


        private string[] PostData(string url, string postData) //! $bugtype, $email, $description, $cpuname, $cpucore, $ram, $os, $ver
        {
            string[] resp = { };
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(postData);

                WebRequest request = WebRequest.Create(url);
                request.Credentials = new NetworkCredential("TOvG6m3uacXE", "xlDMBpNXfzqz", "");
                request.Proxy = null;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (Stream os = request.GetRequestStream())
                {
                    os.Write(data, 0, data.Length);
                    os.Close();
                }

                WebResponse response = request.GetResponse();

                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    resp = sr.ReadToEnd().Split(';');
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resp;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txbDesc.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                bwSendReport.RunWorkerAsync();
                //test();
            }
            else
            {
                MessageBox.Show(Resources.Please_Fill, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            textBox1.Text = "Loading...";
            RemoteIp = ip.Getip();
            textBox1.Text = "Cpu: " + getSys.GetProcessorNameL() + Environment.NewLine + "Core: " + count + Environment.NewLine + "Total Memory: " + getSys.getmemory() + "Mb" + Environment.NewLine + "Operation System: " + getSys.getOS();
        }

        private void bwSendReport_DoWork(object sender, DoWorkEventArgs e)
        {
            send.SendError("report", txbMail.Text, cbBugType.Text, txbDesc.Text, getSys.GetProcessorName(), count.ToString(), getSys.getmemory().ToString(),
          getSys.getOS(), "Prog: " + Launcher.Launcher.CurrProgVer + "," + " Emu: " + Launcher.Launcher.CurrEmuVer);
            
            if (cbLogs.Checked)
                send.zipLogs();
        }

        private void bwSendReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            MessageBox.Show("Thank you for the report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

    }
}
