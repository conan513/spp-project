using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MySQLClass;
using SppLauncher.Properties;

namespace SppLauncher.Windows
{
    public partial class LanSwitcher : Form
    {
        public static bool Available, updateYes, allowCheck = true, FirstRun = false, allowUsageStat = true;
        public static string ip, user, pass, db, port, currVer = "1.0.1", RemoteVer;
        private bool enable;
        private bool thirdrun;
        private bool update;

        public LanSwitcher()
        {
            InitializeComponent();
            SaveLoad();
           // bwUpdate.RunWorkerAsync();
           // bwSql.RunWorkerAsync();
        }


        private void SaveLoad()
        {
            ip = "127.0.0.1";
            user = "root";
            pass = "123456";
            db = "realmd";
            port = "3310";
        }


        private bool CheckLan()
        {
            try
            {
                thirdrun = FirstRun;
                if (FirstRun)
                {
                    enable = true;
                }
                SaveLoad();
                var client = new MySQLClient(ip, db, user, pass, Convert.ToInt32(port));
                string lan = client.Select("realmlist", "id='1'")["address"];
                if (lan == "127.0.0.1")
                {
                    if (!thirdrun)
                    {
                        rB_offline.Checked = true;
                    }
                    if (!enable)
                        txbLanip.Enabled = false;

                    enable = false;

                    txbLanip.Text = LocalIPAddress().ToString();
                    return true;
                }

                rB_lan.Checked = true;
                txbLanip.Text = lan;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private IPAddress LocalIPAddress()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //var settings = new SettingsForm();
            //settings.Show();
        }

        private void rB_offline_CheckedChanged(object sender, EventArgs e)
        {
            txbLanip.Enabled = false;
        }

        private void rB_lan_CheckedChanged(object sender, EventArgs e)
        {
            txbLanip.Enabled = true;

            if (!allowCheck)
            {
                CheckLan();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            UpdateSql();
        }

        private void UpdateSql()
        {
            var client = new MySQLClient(ip, db, user, pass, Convert.ToInt32(port));

            if (!rB_offline.Checked)
            {
                client.Update("realmlist", "address='" + txbLanip.Text + "'", "id='1'");
            }
            else
            {
                client.Update("realmlist", "address='127.0.0.1'", "id='1'");
            }
        }

        private void bwUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var client = new WebClient();
                Stream stream = client.OpenRead("http://dl.dropbox.com/u/7587303/Updates/SingleCoreLanSwitcher.txt");
                var reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                Available = true;
                RemoteVer = content;
                if (content != currVer)
                {
                    if (
                        MessageBox.Show("New Version Available: V" + content + "\n" + "You want to download?",
                                        "New Version", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly) == DialogResult.Yes)
                    {
                        updateYes = true;
                    }
                }
            }
            catch (Exception)
            {
                Available = false;
            }
        }

        private void bwUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwUsageStatSender.RunWorkerAsync();
            if (updateYes)
            {
                var update = new Update();
                update.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.Show();
        }

        private void bwSql_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckLan();
        }

        public void saveMethod()
        {
            XmlTextWriter writer = new XmlTextWriter("config.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteComment(DateTime.Now.ToString());

            writer.WriteStartElement("ConnectionSettings");
            writer.WriteStartElement("ConnectParameters");
            writer.WriteElementString("IP", ip);
            writer.WriteElementString("User", user);
            writer.WriteElementString("Database", db);
            writer.WriteElementString("Port", port);
            writer.WriteEndElement();
            writer.Close();
            //        public static string ip, user, pass, db, port, currVer = "1.0.0", RemoteVer;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //saveMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //saveMethod();

        }
    }
}