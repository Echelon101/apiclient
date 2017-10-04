using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ShopwareApi
{
    public class ApiRequestExecutor
    {
        public ApiResponse<TResponse> Execute<TResponse>(IRestClient client, ApiRequest apiRequest)
        {
            var restRequest = new RestRequest(apiRequest.Url, apiRequest.Method);
            restRequest.RequestFormat = DataFormat.Json;

            if(apiRequest.Parameters != null)
            {
                foreach (KeyValuePair<string, string> parameter in apiRequest.Parameters)
                {
                    restRequest.AddUrlSegment(parameter.Key, parameter.Value);
                }
            }

            restRequest.AddParameter("application/json; charset=utf8", apiRequest.Body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(restRequest);

            if(response.ErrorException != null)
            {
                Debug.WriteLine("Api Error:");
                Debug.WriteLine(response.ErrorException.Message);
            }
            else
            {
                string content = response.Content;
                Debug.WriteLine(content);

                ApiResponse<TResponse> apiResponse = this.ConvertResponseStringToObject<TResponse>(content);

                return apiResponse;
            }
            return null;
        }

        private ApiResponse<A> ConvertResponseStringToObject<A>(string responseString)
        {
            return JsonConvert.DeserializeObject<ApiResponse<A>>(responseString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }
    }
}
