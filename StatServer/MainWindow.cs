using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace StatServer
{

    public partial class Statistics : Form
    {

        private readonly DateTime _startTime = DateTime.Now;
        private DateTime dt1 = DateTime.Now;
        private int _ccGui, _Lanswitcher, _report, _resChanger, _wowAccountCreator;
        private Thread _listenThread;
        private TcpListener _tcpListener;
        private string[] _att = new string[8];
        private string savepath;

        public Statistics()
        {
            InitializeComponent();
            GetProccess();
            timerUp.Start();
            timerSave.Start();
            StatusChange("Not Connected");

            NotifyBallon(1000, "Counter", "Server Started!\nAll Count: " + _ccGui);

            ReadXml();

            //NotifyCounter.Text = "All Count: " + _ccGui.ToString(CultureInfo.InvariantCulture);

            Bitmap(false);
        }

        private void StatusChange (string msg)
        {
            //  ssStatus.Text = msg;
        }

        private void NotifyBallon(int timeout, string title, string msg)
        {
            NotifyCounter.ShowBalloonTip(timeout, title, msg, ToolTipIcon.Info);
        }

        private void GetProccess()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Server is already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        private void Bitmap (bool backup)
        {
            var bmp = new Bitmap(300, 300);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                string s = "Compiler Usage: " + _ccGui.ToString(CultureInfo.InvariantCulture) + "\nSwitcher Usage: " +
                           _Lanswitcher.ToString(CultureInfo.InvariantCulture) + "\nRes Changer: " +
                           _resChanger.ToString(CultureInfo.InvariantCulture) + "Account Creator: " +
                           _wowAccountCreator.ToString(CultureInfo.InvariantCulture);
                var drawFont = new Font("Arial", 11);
                var rectf = new RectangleF(0, 100, 500, 500);

                g.DrawString(s, drawFont, Brushes.Black, rectf);

                bmp.Save("dynamic_pic.bmp");

                if (backup)
                    File.Copy("dynamic_pic.bmp", "D:\\Dropbox\\Public\\Updates\\dynamic_pic.png", true);
            }
        }

        private void LoadStat ()
        {
            int all = _ccGui + _Lanswitcher + _resChanger + _wowAccountCreator;

            //Write label
            lblCompiler.Text = _ccGui.ToString(CultureInfo.InvariantCulture);
            lblAcc.Text = _wowAccountCreator.ToString(CultureInfo.InvariantCulture);
            lblLanSwitch.Text = _Lanswitcher.ToString(CultureInfo.InvariantCulture);
            lblRes.Text = _resChanger.ToString(CultureInfo.InvariantCulture);
            lblReport.Text = _report.ToString(CultureInfo.InvariantCulture);

            //all
            lblAll.Text = all.ToString(CultureInfo.InvariantCulture);
            NotifyCounter.Text = all.ToString(CultureInfo.InvariantCulture);
            NotifyCounter.Text = "All Count: " + all;
        }

        private void WriteError (string errMsg)
        {
            File.WriteAllText(@"ErrorMsg.txt", errMsg, Encoding.UTF8);
        }

        private void SaveXml()
        {
            try
            {
                var writer = new XmlTextWriter(savepath + "counter.xml", Encoding.UTF8)
                {
                    Formatting = Formatting.Indented
                };

                writer.WriteStartDocument();
                writer.WriteComment(DateTime.Now.ToString(CultureInfo.InvariantCulture));
                writer.WriteStartElement("Save");
                writer.WriteElementString("Compiler", _ccGui.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("ResChanger", _resChanger.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("LanSwitcher", _Lanswitcher.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("WowAccCreator", _wowAccountCreator.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("Report", _report.ToString(CultureInfo.InvariantCulture));
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nWrited error to ErrorMsg.txt", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                WriteError(ex.Message);
            }
        }

        private void ReadXml ()
        {
            if (File.Exists("counter.xml")) //not exist? run SaveXML and create it.
            {
                try
                {
                    var doc = new XmlDocument();
                    doc.Load("counter.xml");
                    XmlElement root = doc.DocumentElement;
                    XmlNodeList nodes = root.SelectNodes("/Save");

                    foreach (XmlNode node in nodes)
                    {
                        _ccGui = Convert.ToInt32(node["Compiler"].InnerText);
                        _resChanger = Convert.ToInt32(node["ResChanger"].InnerText);
                        _Lanswitcher = Convert.ToInt32(node["LanSwitcher"].InnerText);
                        _wowAccountCreator = Convert.ToInt32(node["WowAccCreator"].InnerText);
                        _report = Convert.ToInt32(node["Report"].InnerText);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nWrited error to ErrorMsg.txt", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    WriteError(ex.Message);
                }
            }
            else
            {
                SaveXml();
            }
        }

        private void Server ()
        {
            _tcpListener = new TcpListener(IPAddress.Any, 5003);
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
                        _ccGui++;
                        NotifyBallon(500, "Used Compiler", "CC GUI All: " + _ccGui);
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Compiler");
                        break;
                    case "1":
                        _resChanger++;
                        NotifyBallon(500, "Used Resolution Changer", "Resolution Changer All: " + _resChanger);
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Res Change");
                        break;
                    case "2":
                        _Lanswitcher++;
                        NotifyBallon(500, "Used LanSwitcher", "Lan Switcher All: " + _Lanswitcher);
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Lan Changer");
                        break;
                    case "3":
                        _wowAccountCreator++;
                        NotifyBallon(500, "Used Wow Account Creator", "Wow Acc All: " + _wowAccountCreator);
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") + "Wow Account Creator");
                        break;
                    case "-reset":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") +
                                            encoder.GetString(message, 0, bytesRead));
                        ResetCommand();
                        break;
                    case "-picupdate":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") +
                                            encoder.GetString(message, 0, bytesRead));
                        UpdateCommand();
                        break;
                    case "-backup":
                        lbHistory.Items.Add(dt.ToString("(" + "HH:mm" + ") ") +
                                            encoder.GetString(message, 0, bytesRead));
                        backup();
                        break;

                }
                dt1 = DateTime.Now;
                string date = dt1.ToString("yyy.MM.dd");

                _att = report.Split(';');

                if (_att[0] == "report")
                {
                    string appendtext2 = Environment.NewLine + "####################" + dt.ToString() +
                                         "####################" +
                                         Environment.NewLine;

                    string appendText = "Mail: " + _att[1] + Environment.NewLine + "Bug Type: " + _att[2] +
                                        Environment.NewLine + "Descreption: " + _att[3] + Environment.NewLine +
                                        "Cpu: " +
                                        _att[4] + Environment.NewLine + "Cpu Core: " + _att[5] + Environment.NewLine +
                                        "Total MEmory: " + _att[6] + Environment.NewLine + "Operation System: " +
                                        _att[7] + Environment.NewLine + "Version: " + _att[8] + Environment.NewLine;

                    File.AppendAllText("D:\\Dropbox\\Conan_shared\\Report\\" + date + ".txt",
                        appendtext2 + appendText);
                    lbHistory.Items.Add(dt1.ToString("(" + "HH:mm" + ") ") + "Report received.");
                    NotifyBallon(500, "Report Received", "Report All: " + _report);
                    _report++;
                }

                lbHistory.TopIndex = lbHistory.Items.Count - 1;
                LoadStat();
                Bitmap(false);
            }

            tcpClient.Close();
        }

        private void backup()
        {
            File.Copy("counter.xml", "D:\\Dropbox\\Public\\Updates\\backup\\backup.xml", true);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            Server();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void UpdateCommand()
        {
            Bitmap(true);
        }

        private void ResetCommand()
        {
            _ccGui = 0;
            _resChanger = 0;
            _Lanswitcher = 0;
            _wowAccountCreator = 0;
            SaveXml();
            LoadStat();
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
            SaveXml();
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
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu",
                    BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(NotifyCounter, null);
                NotifyCounter.ContextMenuStrip = cmsUp;
            }
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            LoadStat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadXml();
            LoadStat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan delta = DateTime.Now - _startTime;
            tssUptime.Text = delta.Hours.ToString(CultureInfo.InvariantCulture) + "h " +
                             delta.Minutes.ToString(CultureInfo.InvariantCulture) + "m " +
                             delta.Seconds.ToString(CultureInfo.InvariantCulture) + "s";
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            SaveXml();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.ShowNewFolderButton = true;
                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    savepath = dlg.SelectedPath;
                    SaveXml();
                }
            }
        }

        private void NotifyCounter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

    }

}
