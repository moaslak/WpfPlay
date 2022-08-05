using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfPlay.Database
{
    public class MySQLConnecter
    {
        private MySQLConnecter()
        {

        }
        public string server { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string databaseName { get; set; }
        private MySqlConnection Connection { get; set; }        
        private static MySQLConnecter instance = null;
        public static MySQLConnecter Instance()
        {
            if(instance == null)
                instance = new MySQLConnecter();
            return instance;
        }

        public bool Connected()
        {
            if(Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", server, databaseName, username, password);
                Connection = new MySqlConnection(connectionString);
                Connection.Open();
            }
            return true;
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
