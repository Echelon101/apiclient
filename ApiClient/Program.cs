using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System.Diagnostics;


namespace ApiClient
{
    class Program
    {
        

        static RestClient restClient = new RestClient(targetBaseUrl)
        {
            Authenticator = new HttpBasicAuthenticator(username,apiKey)
        };

        static string targetBaseUrl = "null";
        static string username = "demo";
        static string apiKey = "RCiG7xCeTwHm0IFnNDXtwi2OFZPR5tMmv2PqJi9q";

        static void Main(string[] args)
        {
            string resource = "api/articles?limit=7117";
                

            RestRequest restRequest = new RestRequest(resource, Method.GET);
            var content = GetRestResponse(restRequest);
                

             
            Console.WriteLine(content);
            Console.ReadKey();
            
           
        }

        static string GetRestResponse (IRestRequest restRequest)
        {
            IRestResponse response = restClient.Execute(restRequest);
            if(response.ErrorException != null)
            {
                const string message = "Error retrievíng response. Check inner details for more info";
                var ApiException = new ApplicationException(message, response.ErrorException);
                throw ApiException;
            }

            return response.Content;
        }
    }
}
