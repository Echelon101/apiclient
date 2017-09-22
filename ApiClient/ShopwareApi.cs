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
        string BaseUrl = null;

        readonly string _username;
        readonly string _secretKey;

        public ShopwareApi(string baseUrl, string username, string secretKey)
        {
            BaseUrl = baseUrl;
            _username = username;
            _secretKey = secretKey;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new System.Uri(BaseUrl);
            client.Authenticator = new HttpBasicAuthenticator(_username, _secretKey);

            var response = client.Execute<T>(request);

            if(response.ErrorException != null)
            {
                const string message = "Error retrieving response. Check inner details for more info";
                var shopwareException = new ApplicationException(message, response.ErrorException);
                throw shopwareException;
            }
            return response.Data;
        }
    }
}
