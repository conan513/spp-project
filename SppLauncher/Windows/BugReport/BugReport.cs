using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SppLauncher.Windows.BugReport
{
    public partial class BugReport : Form
    {
        private readonly int count = Environment.ProcessorCount;
        public static string RemoteIp;
        public static string lol;
        private GetSysInfo getSys;
        private SendReport send;
        public BugReport()
        {
            InitializeComponent();
            getSys = new GetSysInfo();
            send = new SendReport();
            cbBugType.Text = "Aibot";
            
            bwGetSysInfo.RunWorkerAsync();
        }

        public Cursor SetCursor
        {
            set { Cursor = value; }
            get { throw new NotImplementedException(); }
        }


        public static string test
        {
            get { return null; }
            set { ; }
        }

        public void SendError(string report,string bugtype, string email, string desc, string cpu, string cpucore, string ram,string os, string ver)
        {
            try
            {
                
                TcpClient client = new TcpClient();
                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(RemoteIp), 5459);
                client.Connect(serverEndPoint);
                NetworkStream clientStream = client.GetStream();

                UTF8Encoding encoder = new UTF8Encoding();
                byte[] buffer        = encoder.GetBytes(report + ";" + bugtype + ";" + email + ";" + desc + ";" + cpu + ";" + cpucore + ";" + ram + ";" + os + ";" + ver);
                
                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
                client.Close();
                this.Cursor = Cursors.Default;
                MessageBox.Show("Thank you for the report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Can not connect to the reporting server\nPlease try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txbDesc.Text != "")
            {
                Cursor = Cursors.WaitCursor;
                bwSendReport.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please Fill out the Description box.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var client    = new WebClient();
                Stream stream = client.OpenRead("http://dl.dropbox.com/u/7587303/Updates/ip.txt");
                var reader    = new StreamReader(stream);
                RemoteIp      = reader.ReadToEnd();
                
            }
            catch (Exception)
            {
            }

            textBox1.Text = "Loading...";
            textBox1.Text = "Cpu: " + getSys.GetProcessorNameL() + Environment.NewLine + "Core: " + count + Environment.NewLine + "Total Memory: " + getSys.getmemory() + "Mb" + Environment.NewLine + "Operation System: " + getSys.getOS();
        }

        private void bwSendReport_DoWork(object sender, DoWorkEventArgs e)
        {
            send.SendError("report", txbMail.Text, cbBugType.Text, txbDesc.Text, getSys.GetProcessorName(), count.ToString(), getSys.getmemory().ToString(),
          getSys.getOS(), "Prog: " + Launcher.currProgVer + "," + " Emu: " + Launcher.CurrEmuVer);
        }

        private void bwSendReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            Close();
        }

    }
}
