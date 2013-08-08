using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQLClass
{
    class MySQLClient
    {
        readonly MySqlConnection conn;


        #region Constructors
        public MySQLClient(string hostname, string database, string username, string password)
        {
            conn = new MySqlConnection("host=" + hostname + ";database=" + database +";username=" + username +";password=" + password +";");
        }

        public MySQLClient(string hostname, string database, string username, string password, int portNumber)
        {
            conn = new MySqlConnection("host=" + hostname + ";database=" + database + ";username=" + username + ";password=" + password + ";port=" + portNumber +";");
        }

        public MySQLClient(string hostname, string database, string username, string password, int portNumber, int connectionTimeout)
        {
            conn = new MySqlConnection("host=" + hostname + ";database=" + database + ";username=" + username + ";password=" + password + ";port=" + portNumber + ";Connection Timeout=" + connectionTimeout +";");
        }
        #endregion

        #region Open/Close Connection
        private bool Open()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Close()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        
        public void Insert(string table, string column, string value)
        {
            string query = "INSERT INTO " + table + " (" + column + ") VALUES (" + value + ")";

            try
            {
                if (this.Open())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
            }
            catch { }
        }

        public void Update(string table, string SET, string WHERE)
        {
            string query = "UPDATE " + table + " SET " + SET + " WHERE " + WHERE + "";

            if (this.Open())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch { this.Close(); }
            }
        }

        public void Delete(string table, string WHERE) 
        {
            string query = "DELETE FROM " + table + " WHERE " + WHERE + "";

            if (this.Open())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
                catch { this.Close(); }
            }
        }

        public Dictionary<string, string> Select(string table, string WHERE)
        {
            string query = "SELECT * FROM " + table + " WHERE " + WHERE + "";

            Dictionary<string, string> selectResult = new Dictionary<string, string>();

            if (this.Open())
            {
                MySqlCommand cmd           = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                try
                {
                    while (dataReader.Read())
                    {

                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            selectResult.Add(dataReader.GetName(i), dataReader.GetValue(i).ToString());
                        }

                    }
                    dataReader.Close();
                }
                catch { }
                this.Close();

                return selectResult;
            }
            return selectResult;
        }

        public int Count(string table)
        {
            string query    = "SELECT Count(*) FROM " + table + "";
            int Count       = -1;
            if (this.Open())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    Count            = int.Parse(cmd.ExecuteScalar() + "");
                    this.Close();
                }
                catch { this.Close(); }
                return Count;
            }
            return Count;
        }
    }
}
