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
//using System.Windows.Forms;

namespace ApiClient
{
    class Program
    {
        

        static RestClient restClient = new RestClient(targetBaseUrl)
        {
            Authenticator = new HttpBasicAuthenticator(username,apiKey)
        };

        static string targetBaseUrl = "http://shop.localtest.me/";
        static string username = "demo";
        static string apiKey = "RCiG7xCeTwHm0IFnNDXtwi2OFZPR5tMmv2PqJi9q";
        //[STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.Run(new Form1());
            try
            {
                
                
                
                string resource = "api/articles?limit=7117";
                

                RestRequest restRequest = new RestRequest(resource, Method.GET);

                IRestResponse restResponse = restClient.Execute(restRequest);

                if (restResponse.ErrorException != null)
                {
                    const string message = "Error retrieing response. Check inner details for more info.";
                    var restException = new ApplicationException(message, restResponse.ErrorException);
                    throw restException;
                }

                var content = restResponse.Content;
                Console.WriteLine(content);
                Console.ReadKey();
            }catch (ApplicationException e)
            {
                Debug.WriteLine(e);
                Console.Read();
            }
           
        }

        static RestResponse GetRestResponse (IRestRequest restRequest)
        {
            
            return null;
        }
    }
}
