using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLClass;

namespace SppLauncher.Windows
{
    public partial class LanSwitcher : Form
    {
        public static bool Available, updateYes, allowCheck = true, FirstRun = false, allowUsageStat = true;
        public static string ip, user, pass, db, port, currVer = "1.0.1", RemoteVer, test;
        private GetPublicIP GetPublic;
        public LanSwitcher()
        {
            InitializeComponent();
           // cbCh.Text = "Offline";
            GetPublic = new GetPublicIP();
            ip = "127.0.0.1";
            user = "root";
            pass = "123456";
            db = "realmd";
            port = "3310";

            CheckLan();
        }

        private void CheckLan()
        {
            try
            {
                var client = new MySQLClient(ip, db, user, pass, Convert.ToInt32(port));
                string lan = client.Select("realmlist", "id='1'")["address"];
                if (lan == "127.0.0.1")
                {
                    cbCh.Text = "Offline";
                    txbLanip.Text = "127.0.0.1";
                }
                else if (lan == Convert.ToString(LocalIPAddress()))
                {
                    cbCh.Text = "Lan";
                    txbLanip.Text = lan;
                }
                else if (lan == GetPublic.IP())
                {
                    cbCh.Text = "Internet";
                    txbLanip.Text = GetPublic.IP();
                }
            }
            catch (Exception)
            {
            }
        }

        private void cbCh_SelectedIndexChanged(object sender, EventArgs e)
        {
            test = cbCh.Items[cbCh.SelectedIndex].ToString();

            switch (test)
            {
                case "Offline":
                    txbLanip.Text = "127.0.0.1";
                    break;
                case "Lan":
                    txbLanip.Text = Convert.ToString(LocalIPAddress());
                    break;
                case "Internet":
                    txbLanip.Text = GetPublic.IP();
                    break;
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            UpdateSql();
        }

        private void UpdateSql()
        {
            var client = new MySQLClient(ip, db, user, pass, Convert.ToInt32(port));


            client.Update("realmlist", "address='" + txbLanip.Text + "'", "id='1'");

        }
    }
}