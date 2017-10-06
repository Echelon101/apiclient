using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi;
using ShopwareApi.Models.Articles;
using ShopwareApi.Resources;
using System.Threading;
using YamlDotNet.Serialization;
using System.CodeDom.Compiler;
using System.IO;

namespace ApiClientTest
{
    class Program
    {
        private static string url = System.Configuration.ConfigurationSettings.AppSettings["Url"];
        private static string username = System.Configuration.ConfigurationSettings.AppSettings["Username"];
        private static string apiKey = System.Configuration.ConfigurationSettings.AppSettings["ApiKey"];
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("{0}, {1}, {2}", url, username, apiKey);
                TestComponent test = new TestComponent(url, username, apiKey);
                DumpAsYaml(test.Shops("1"));
                Console.WriteLine("------------------------------------------------------");
                DumpAsYaml(test.Shops());
                Console.WriteLine("------------------------------------------------------");
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                
            }
            Console.ReadKey();
        }

        private static void DumpAsYaml(object o)
        {
            var stringBuilder = new StringBuilder();
            var serializer = new Serializer();
            serializer.Serialize(new IndentedTextWriter(new StringWriter(stringBuilder)), o);
            Console.WriteLine(stringBuilder);
        }
    }
}
