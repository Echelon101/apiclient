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
        private string connectionString;
        public int LastError { get; set; }

        public MySqlClient(IPAddress host, decimal port, string uid, string pwd, string database)
        {
            this.connectionString = String.Format("server={0};prot={1};uid={2};pwd={3};database={4}", host,port, uid, pwd, database);
            this.MySqlConnection = new MySqlConnection(this.connectionString);
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
                LastError = ex.Number;
                success = false;
            }
            return success;
        }
        public System.Net.NetworkInformation.PingReply CheckHostConnection(string host)
        {
            try
            {
                System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingReply reply = pingSender.Send(host);
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    return reply;
                }
                else
                {
                    return reply;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            
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
