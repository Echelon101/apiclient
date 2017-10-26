using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net;

namespace DatabaseClient
{
    public class MySqlClient
    {

        private MySqlConnection MySqlConnection;
        public string ConnectionString { get; set; }
        public string[] LastError { get; set; }

        public MySqlClient(string host, decimal port, string uid, string pwd, string database)
        {
            ConnectionString = String.Format("server={0};port={1};uid={2};pwd={3};database={4}", host,port, uid, pwd, database);
            this.MySqlConnection = new MySqlConnection();
            this.MySqlConnection.ConnectionString = ConnectionString;
        }

        public void SetConnectionString(string host, decimal port, string uid, string pwd, string database)
        {
            ConnectionString = String.Format("server={0};prot={1};uid={2};pwd={3};database={4}", host, port, uid, pwd, database);
            this.MySqlConnection.ConnectionString = ConnectionString;
        }
        public bool CheckMySqlConnection()
        {
            bool success = true;
            try
            {
                this.MySqlConnection.Open();
                this.MySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                LastError[0] = ex.Number.ToString();
                LastError[1] = ex.Message;
                success = false;
            }
            return success;
        }

        public List<string> GetSchemes()
        {
            List<string> schemes = new List<string>();
            MySqlCommand command = this.MySqlConnection.CreateCommand();
            command.CommandText = "SHOW DATABASES";
            MySqlDataReader dataReader;
            this.MySqlConnection.Open();
            dataReader = command.ExecuteReader();
            
            while (dataReader.Read())
            {
                for (int i = 0; i < dataReader.FieldCount; i++)
                {
                    schemes.Add(dataReader.GetValue(i).ToString());
                }
            }
            if (this.MySqlConnection.State == ConnectionState.Open)
            {
                this.MySqlConnection.Close();
            }
            return schemes;
        }

        public List<string> GetTables()
        {
            List<string> tables = new List<string>();
            MySqlCommand command = this.MySqlConnection.CreateCommand();
            command.CommandText = "SHOW TABLES";
            MySqlDataReader dataReader;
            this.MySqlConnection.Open();
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                for(int i = 0; i < dataReader.FieldCount; i++)
                {
                    tables.Add(dataReader.GetValue(i).ToString());
                }
            }
            if (this.MySqlConnection.State == ConnectionState.Open)
            {
                this.MySqlConnection.Close();
            }
            return tables;
        }
        

    }
}
