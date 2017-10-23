using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseClient;
using System.Data;
using System.Net;

namespace DatabaseClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                string input = Console.ReadLine();
                if(input.ToLower() == "exit")
                {
                    running = false;
                }
                else
                {
                    IPHostEntry hostEntry = Dns.GetHostEntry(input);
                    foreach (var entry in hostEntry.AddressList)
                    {
                        Console.WriteLine(entry);
                    }
                    Console.WriteLine("-done");
                    foreach (var entry in hostEntry.Aliases)
                    {
                        Console.WriteLine(entry);
                    }
                    Console.WriteLine("--done");
                    Console.WriteLine(hostEntry.HostName);
                    Console.WriteLine("------");
                }
            }
        }
    }
}
