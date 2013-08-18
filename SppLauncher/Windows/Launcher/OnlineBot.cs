using System;
using MySql.Data.MySqlClient;

namespace SppLauncher.OnlineBot
{
    class Onlinebot
    {
        string online;
        public string GetBot()
        {

            try
            {
                if (!Loader.Kill)
                {
                    string InsertQuery    = "SELECT SUM(online) FROM characters";
                    using (var connection = new MySqlConnection(string.Format("server =127.0.0.1;UID=root;PWD=123456;port=3310;database=characters")))
                    {
                        var command = new MySqlCommand(InsertQuery, connection);
                        command.Connection.Open();
                        online = command.ExecuteScalar().ToString();
                        connection.Close();
                        return online;
                    }
                }
                return "N/A";
            }
            catch (Exception)
            {
                return "N/A";
            }
        }
    }
}
