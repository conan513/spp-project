using System;
using MySql.Data.MySqlClient;

namespace SppLauncher.Class
{
    class GetAllChar
    {
        public string GetChar()
        {
            string allChar;
            try
            {
                if (!Loader.Kill)
                {
                    string InsertQuery = "SELECT COUNT(*) FROM characters";
                    using (var connection = new MySqlConnection(string.Format("server =127.0.0.1;UID=root;PWD=123456;port=3310;database=characters")))
                    {
                        var command = new MySqlCommand(InsertQuery, connection);
                        command.Connection.Open();
                        allChar = command.ExecuteScalar().ToString();
                        connection.Close();
                        return allChar;
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
