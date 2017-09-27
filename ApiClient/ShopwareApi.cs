using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers;
using RestSharp.Deserializers;

namespace ApiClient
{
    class ShopwareApi
    {
        private string url;
        private string username;
        private string apiKey;
        private RestClient client;

        public ShopwareApi(string url, string username, string apiKey)
        {
            this.url = url;
            this.username = username;
            this.apiKey = apiKey;

            this.client = new RestClient(url);
            client.Authenticator = new HttpBasicAuthenticator(username, apiKey);
        }
    }
}
