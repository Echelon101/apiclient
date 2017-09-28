using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseClient
{
    public class Client
    {
        private MySqlConnection sqlConnection;
        private string connectionString;

        public Client(string server, string uid, string password, string database)
        {
            this.connectionString = "server=" + server + ";uid="+ uid + ";pwd=" + password + ";database=" + database;
        }
        public void Connector()
        {
            this.sqlConnection = new MySqlConnection();
            this.sqlConnection.ConnectionString = this.connectionString;
            this.sqlConnection.Open();
        }
    }
}
