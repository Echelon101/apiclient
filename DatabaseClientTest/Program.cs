using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClient;
using System.Data;

namespace DatabaseClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("localhost", "root", "", "export");
            /*
            List<string> fields = client.SelectQuery("*", "exportlog");

            foreach (string field in fields)
            {
                Console.WriteLine(field);
            }

            */

            List<string> tables = client.GetTables();

            foreach (string table in tables)
            {
                Console.WriteLine(table);
            }

            Console.ReadKey();
        }
    }
}
