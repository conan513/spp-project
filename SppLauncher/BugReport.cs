using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SppLauncher
{
    public partial class BugReport : Form
    {
        private readonly int count = Environment.ProcessorCount;
        private string RemoteIp;

        public BugReport()
        {
            InitializeComponent();
            cbBugType.Text = "Aibot";
            bwGetSysInfo.RunWorkerAsync();
        }

        public int getmemory()
        {
            return Convert.ToInt32(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024);
        }

        private string GetProcessorName()
        {
            string ProcessorName = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject mo in mos.Get())
                ProcessorName = mo["Name"] + "@" + mo["maxclockspeed"] + "Mhz";

            return ProcessorName;
        }

        private string GetProcessorNameL()
        {
            string ProcessorName = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject mo in mos.Get())
                ProcessorName = mo["Name"].ToString();

            return ProcessorName;
        }

        private string getOS()
        {
            var name =
                (from x in
                     new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().OfType<ManagementObject>()
                 select x.GetPropertyValue("Caption")).First();
            return name != null ? name.ToString() : "Unknown";
        }

        public void SendError(string report,string bugtype, string email, string desc, string cpu, string cpucore, string ram,string os, string ver)
        {
            try
            {
                TcpClient client = new TcpClient();

                IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(RemoteIp), 5003);

                client.Connect(serverEndPoint);

                NetworkStream clientStream = client.GetStream();

                UTF8Encoding encoder = new UTF8Encoding(); //currprogver,curremuver
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
                this.Cursor = Cursors.WaitCursor;
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
            textBox1.Text = "Cpu: " + GetProcessorNameL() + Environment.NewLine + "Core: " + count + Environment.NewLine + "Total Memory: " + getmemory() + "Mb" + Environment.NewLine + "Operation System: " + getOS();
        }

        private void bwSendReport_DoWork(object sender, DoWorkEventArgs e)
        {
            SendError("report", txbMail.Text, cbBugType.Text, txbDesc.Text, GetProcessorName(), count.ToString(), getmemory().ToString(),
          getOS(), "Prog: " + Launcher.currProgVer + "," + " Emu: " + Launcher.CurrEmuVer);
        }

    }
}
