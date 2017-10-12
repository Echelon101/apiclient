using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DatabaseClient
{
    public class MySqlClient
    {

        private MySqlConnection MySqlConnection;
        private string connectionString;
        public int LastError { get; set; }

        public MySqlClient(string host, string uid, string pwd, string database)
        {
            this.connectionString = String.Format("server={0};uid={1};pwd={2};database={3}", host, uid, pwd, database);
            this.MySqlConnection = new MySqlConnection(this.connectionString);
        }
        public bool CheckConnection()
        {
            bool success = true;
            try
            {
                this.MySqlConnection.Open();
                this.MySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                LastError = ex.Number;
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
        

    }
}
