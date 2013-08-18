using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SppLauncher.Windows.BugReport
{
    public partial class BugReport : Form
    {
        private readonly int count = Environment.ProcessorCount;
        public static string RemoteIp;
        public static string lol;
        private readonly GetSysInfo getSys;
        private readonly SendReport send;
        private readonly GetServerIP ip;
        public BugReport()
        {
            InitializeComponent();
            getSys = new GetSysInfo();
            send = new SendReport();
            ip = new GetServerIP();
            cbBugType.Text = "Aibot";
            
            bwGetSysInfo.RunWorkerAsync();
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
            RemoteIp = ip.Getip();
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
