using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using StatServer.Class;

namespace StatServer
{
    #region [ Variables ]

    public partial class Statistics : Form
    {
        private readonly DateTime _startTime = DateTime.Now;
        public string date;
        private DateTime dt1 = DateTime.Now;
        public static int _report;
        private Thread _listenThread;
        private TcpListener _tcpListener;
        private string[] _att = new string[8];
        public static string savepath;
        private readonly XmlReadW xmlReadWrite;
        private readonly GetPublicIP get = new GetPublicIP();
        private readonly AutoMail Mail = new AutoMail();
        private Thread FilelistenThread;
        private TcpListener FiletcpListener;

    #endregion

        #region [ Constructor ]

        public Statistics()
        {
            InitializeComponent();
            xmlReadWrite = new XmlReadW();
            GetProccess();
            timerUp.Start();
            timerSave.Start();
            StatusChange("Not Connected");
            xmlReadWrite.ReadXml();
            Getip.Start();
        }

        #endregion

        #region [ ReportServer ]

        private void MsgServer()
        {
            _tcpListener  = new TcpListener(IPAddress.Any, 5459);
            _listenThread = new Thread(ListenForClients);
            _listenThread.Start();
        }

        private void ListenForClients ()
        {
            _tcpListener.Start();

            while (true)
            {
                StatusChange("Online");
                TcpClient client = _tcpListener.AcceptTcpClient();
                var clientThread = new Thread(HandleClientComm);
                clientThread.Start(client);
            }
        }

        private void HandleClientComm (object client)
        {
            var tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            var message = new byte[4096];

            while (true)
            {
                int bytesRead;
                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    MessageBox.Show("Some Exception: Socket Error", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    break;
                }

                if (bytesRead == 0)
                {
                    break;
                }

                var encoder = new UTF8Encoding();

                DateTime dt = DateTime.Now;

                encoder.GetString(message, 0, bytesRead);
                string report = encoder.GetString(message, 0, bytesRead);

                switch (encoder.GetString(message, 0, bytesRead))
                {
                    case "0":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Compiler");
                        break;
                    case "1":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Res Change");
                        break;
                    case "2":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Lan Changer");
                        break;
                    case "3":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Wow Account Creator");
                        break;
                }
                dt1 = DateTime.Now;
                date = dt1.ToString("yyy.MM.dd");
                string date2 = dt1.ToString("HH:mm");
                
                _att = report.Split(';');

                if (_att[0] == "report")
                {
                    string appendText = "Mail: " + _att[1] + Environment.NewLine + "Bug Type: " + _att[2] + Environment.NewLine +
                                        "Cpu: " +
                                        _att[4] + Environment.NewLine + "Cpu Core: " + _att[5] + Environment.NewLine +
                                        "Total Mmory: " + _att[6] + Environment.NewLine + "Operation System: " +
                                        _att[7] + Environment.NewLine + "Version: " + _att[8] + Environment.NewLine + "Descreption: "+ Environment.NewLine + _att[3];

                    //string appendText = "Mail: " + _att[1] + Environment.NewLine + "Bug Type: " + _att[2] +
                    //Environment.NewLine + "Descreption: " + _att[3] + Environment.NewLine +
                    //"Cpu: " +
                    //_att[4] + Environment.NewLine + "Cpu Core: " + _att[5] + Environment.NewLine +
                    //"Total Mmory: " + _att[6] + Environment.NewLine + "Operation System: " +
                    //_att[7] + Environment.NewLine + "Version: " + _att[8] + Environment.NewLine;

                    string writetext = _att[1];
                    if (_att[1].Contains("@"))
                    {
                        Thread t = new Thread(() => Mail.Send(_att[1], appendText, date));
                        t.Start();
                    }

                    if(!Directory.Exists("D:\\Dropbox\\Conan_shared\\Report\\" + date))
                    {
                        Directory.CreateDirectory("D:\\Dropbox\\Conan_shared\\Report\\" + date);
                    }

                    int fileCount = Directory.GetFiles("D:\\Dropbox\\Conan_shared\\Report\\" + date, "*.*", SearchOption.TopDirectoryOnly).Length;

                    File.AppendAllText("D:\\Dropbox\\Conan_shared\\Report\\" + date + "\\" + (fileCount +1) +".txt", report + ";" + date2);
                    lbHistory.Items.Add(dt1.ToString("(" + "HH:mm" + ") ") + "Report received.");
                    _report++;
                }

                lbHistory.TopIndex = lbHistory.Items.Count - 1;
                LoadStat();
            }
            tcpClient.Close();
        }

        #endregion

        #region [ Log Server ]
        private void FileServer()
        {
            FiletcpListener  = new TcpListener(IPAddress.Any, 5460);
            FilelistenThread = new Thread(FileListenForClients);
            FilelistenThread.Start();
        }

        private void FileListenForClients()
        {
            FiletcpListener.Start();

            while (true)
            {
                TcpClient client = FiletcpListener.AcceptTcpClient();
                var clientThread = new Thread(Fileserverstart);
                clientThread.Start(client);
            }
        }

        public void Fileserverstart(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            int bufferSize      = 1024;
            NetworkStream netStream;
            int bytesRead = 0;
            int allBytesRead = 0;

            netStream = tcpClient.GetStream();

            // Read length of incoming data
            byte[] length  = new byte[4];
            bytesRead      = netStream.Read(length, 0, 4);
            int dataLength = BitConverter.ToInt32(length, 0);

            // Read the data
            int bytesLeft = dataLength;
            byte[] data = new byte[dataLength];

            while (bytesLeft > 0)
            {

                int nextPacketSize = (bytesLeft > bufferSize) ? bufferSize : bytesLeft;
                bytesRead          = netStream.Read(data, allBytesRead, nextPacketSize);
                allBytesRead      += bytesRead;
                bytesLeft         -= bytesRead;
            }

            DateTime dt = DateTime.Now;
            date = dt.ToString("yyy.MM.dd");
            int fileCount = Directory.GetFiles("D:\\Dropbox\\Conan_shared\\Report\\" + date, "*.*", SearchOption.TopDirectoryOnly).Length;

            if (!Directory.Exists("D:\\Dropbox\\Conan_shared\\Report\\Logs\\" + date))
            {
                Directory.CreateDirectory("D:\\Dropbox\\Conan_shared\\Report\\Logs\\" + date);
            }

            File.WriteAllBytes("D:\\Dropbox\\Conan_shared\\Report\\Logs\\" + date + "\\" + fileCount + "_Logs.zip", data);

            lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Logs Received");

            netStream.Close();
            tcpClient.Close();

        }
        #endregion

        #region [ Other Methods ]

        private void LoadStat()
        {
            lblReport.Text = _report.ToString(CultureInfo.InvariantCulture);
        }

        private void GetProccess()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Server is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void NotifyBallon(int timeout, string title, string msg)
        {
            NotifyCounter.ShowBalloonTip(timeout, title, msg, ToolTipIcon.Info);
        }

        private void StatusChange(string msg)
        {
            //  ssStatus.Text = msg;
        }

        #endregion

        #region [ Click & Form Events ]

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void NotifyCounter_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            LoadStat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlReadWrite.SaveXml();
            Environment.Exit(0);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void NotifyCounter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                NotifyCounter.ContextMenuStrip = cmsUp;
                MethodInfo mi                  = typeof(NotifyIcon).GetMethod("ShowContextMenu",
                    BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(NotifyCounter, null);
                NotifyCounter.ContextMenuStrip = cmsUp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.ShowNewFolderButton = true;
                DialogResult result     = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    savepath = dlg.SelectedPath;
                    xmlReadWrite.SaveXml();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xmlReadWrite.ReadXml();
            LoadStat();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            LoadStat();
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            MsgServer();
            FileServer();
        }

        #endregion

        #region [ Timers ]

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = DateTime.Now - _startTime;
            tssUptime.Text = delta.Days.ToString(CultureInfo.InvariantCulture) + "d " +
                             delta.Hours.ToString(CultureInfo.InvariantCulture) + "h " +
                             delta.Minutes.ToString(CultureInfo.InvariantCulture) + "m " +
                             delta.Seconds.ToString(CultureInfo.InvariantCulture) + "s";
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            xmlReadWrite.SaveXml();
        }

        private void Getip_Tick(object sender, EventArgs e)
        {
            string ip = get.IP();
            if (ip != File.ReadAllText(@"D:\Dropbox\Public\Updates\ip.txt"))
            {
                File.WriteAllText(@"D:\Dropbox\Public\Updates\ip.txt", ip);
            }
        }

        #endregion
    }
}
