using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace Api_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            DateTime date = dateTime.Date;
            string jsonPath = @"c:\www\rest\json\" + date.ToString("yyyy.MM.dd") + ".json";
            var client = new RestClient("http://shop.localtest.me/");
            client.Authenticator = new HttpBasicAuthenticator("demo", "RCiG7xCeTwHm0IFnNDXtwi2OFZPR5tMmv2PqJi9q");

            var reqeuest = new RestRequest("api/articles/{id}", Method.GET);
            reqeuest.AddUrlSegment("id", "");
            reqeuest.AddHeader("Content-Type", "application/json");

            IRestResponse response = client.Execute(reqeuest);
            var content = response.Content;

            if (response.ErrorException != null)
            {
                Console.WriteLine("ERROR: "+ response.ErrorException.Message);
                Console.ReadKey();
            }

            if (!File.Exists(jsonPath))
            {
                File.WriteAllText(jsonPath, content, Encoding.UTF8);
            }
            Console.WriteLine(content);
            Console.ReadKey();
            
        }
    }
}
