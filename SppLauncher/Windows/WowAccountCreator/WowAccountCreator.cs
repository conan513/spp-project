using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SppLauncher.Properties;
using SppLauncher.Windows.WowAccountCreator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace WowAccountCreator
{
    public partial class WowaccountCreator : Form
    {
        public static string ip, user, pass, db, port, gmlvl, accType;
        private readonly GenHash Generate;

        public WowaccountCreator()
        {
            InitializeComponent();
            Generate = new GenHash();
            cbEx.Text = "WOTLK";
            cbType.Text = "Player";
            bwUpdate.RunWorkerAsync();

            ip = "127.0.0.1";
            user = "root";
            pass = "123456";
            db = "realmd";
            port = "3310";
        }

        public void InsertSqlTrinity()
        {
            try
            {
                string str = Generate.Sha1_hash(txbUser.Text, txbPass.Text);
                string InsertQuery = "INSERT INTO account (username, sha_pass_hash, expansion) VALUES ('" + txbUser.Text.ToUpper() + "', '" + str.ToUpper() + "', '" + accType + "');SELECT @@Identity";
                using (MySqlConnection connection = new MySqlConnection(string.Format("server={0};UID={1};PWD={2};port={3};database={4}", ip, user, pass, port, db)))
                {
                    MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                    command.Connection.Open();
                    command.CommandText = InsertQuery;
                    string id = command.ExecuteScalar().ToString();
                    string InsertAdmin = "INSERT INTO account_access (id, gmlevel, realmID) VALUES ('" + id + "','" + gmlvl + "' , '1')";
                    if (gmlvl != "0")
                    {
                        new MySqlCommand(InsertAdmin, connection).ExecuteNonQuery();
                    }
                    MessageBox.Show(Resources.WowaccountCreator_InsertSqlTrinity_Account_created_successfully__ +
                        txbUser.Text + Resources.WowaccountCreator_InsertSqlTrinity_ +
                        cbType.Items[cbType.SelectedIndex], "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    txbUser.Text = "";
                    txbPass.Text = "";
                    connection.Close();
                }
            }
            catch (MySqlException exception)
            {
                MessageBox.Show(exception.Message.Contains("Duplicate") ? Resources.WowaccountCreator_InsertSqlTrinity_Username_is_already_taken_ : exception.Message,
                    "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txbUser.TextLength < 3)
            {
                MessageBox.Show(Resources.WowaccountCreator_btnCreate_Click_Your_username_must_be_at_least_4_characters_long__, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txbPass.TextLength < 6)
                {
                    MessageBox.Show(Resources.WowaccountCreator_btnCreate_Click_Your_password_must_be_at_least_6_characters_long__, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txbPass.Text = "";
                }
                else
                {
                    InsertSqlTrinity();
                }
            }
        }


        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gmlvl = cbType.Items[cbType.SelectedIndex].ToString();
            switch (gmlvl)
            {
                case "Player":
                    gmlvl = "0";
                    break;
                case "Moderator":
                    gmlvl = "1";
                    break;
                case "GameMaster":
                    gmlvl = "2";
                    break;
                case "Admin":
                    gmlvl = "3";
                    break;
            }
        }

        private void cbEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            accType = cbEx.Items[cbEx.SelectedIndex].ToString();

            switch (accType)
            {
                case "WOTLK":
                    accType = "2";
                    break;
                case "Cataclysm":
                    accType = "3";
                    break;
                case "BC":
                    accType = "1";
                    break;
                case "Vanilla":
                    accType = "0";
                    break;
            }
        }

        //public void usagestatistics()
        //{
        //    try
        //    {
        //        TcpClient client = new TcpClient();

        //        IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse("81.182.218.117"), 5003);

        //        client.Connect(serverEndPoint);

        //        NetworkStream clientStream = client.GetStream();

        //        ASCIIEncoding encoder = new ASCIIEncoding();
        //        byte[] buffer = encoder.GetBytes("3");

        //        clientStream.Write(buffer, 0, buffer.Length);
        //        clientStream.Flush();
        //        client.Close();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //}


    }

}
