using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ShopwareApi.Resources
{
    public abstract class SuperResource<TResponse>
    {
        protected String resourceUrl;

        protected IRestClient Client { get; set; }

        public SuperResource(IRestClient client)
        {
            this.Client = client;
        }

        public TResponse Get(int id)
        {
            try
            {
                return this.Get(id.ToString());
            }
            catch (Exception e)
            {
                // Pass exception to next level.
                throw e;
            }
        }

        public TResponse Get(string id)
        {
            ApiResponse<TResponse> response = ConvertResponseStringToObject<TResponse>(this.ExecuteGet(id));
            if (!response.success)
            {
                throw new Exception(response.message);
            }
            return response.data;
        }
        public string GetJsonResponse(int id)
        {
            try
            {
                return this.GetJsonResponse(id.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetJsonResponse(string id)
        {
            string response = this.ExecuteGet(id);
            Debug.WriteLine(response);
            return response;
        }

        public List<TResponse> GetAll()
        {
            ApiResponse<List<TResponse>> response = ConvertResponseStringToObject<List<TResponse>>(ExecuteGetAll());
            if (!response.success)
            {
                throw new Exception(response.message);
            }
            return response.data;
        }

        public void Add(TResponse data)
        {
            String response = this.ExecuteAdd(data);
        }

        public void Update(TResponse data)
        {
            String response = this.ExecuteUpdate(data, "");
        }

        public void Delete(string id)
        {
            String response = this.ExecuteDelete(id);
        }

        protected ApiResponse<A> ConvertResponseStringToObject<A>(string responseString)
        {
            return JsonConvert.DeserializeObject<ApiResponse<A>>(responseString, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        protected String ExecuteDelete(string id)
        {
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("id", id));
            String response = this.Execute(this.resourceUrl + "/{id}", Method.DELETE, parameters);
            return response;
        }

        protected String ExecuteUpdate(TResponse data ,string id)
        {
            String json = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Debug.WriteLine(json);

            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<string, string>("id", id));
            return this.Execute(this.resourceUrl + "/{id}", Method.PUT, parameters, json);
        }

        protected String ExecuteAdd(TResponse data)
        {
            String json = JsonConvert.SerializeObject(data, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Debug.WriteLine(json);
            return this.Execute(this.resourceUrl, Method.POST, null, json);
        }

        protected String ExecuteGet(string id)
        {
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<string, string>>();
            parameters.Add(new KeyValuePair<String, String>("id", id));
            String response = this.Execute(this.resourceUrl + "/{id}", Method.GET, parameters);
            return response;
        }

        protected String ExecuteGetAll()
        {
            List<KeyValuePair<String, String>> parameters = new List<KeyValuePair<string, string>>();

            return this.Execute(this.resourceUrl, Method.GET, parameters);
        }

        private String Execute(ApiRequest request)
        {
            return "";
        }
        
        private String Execute(string resource, RestSharp.Method method, List<KeyValuePair<String, String>> parameters)
        {
            return Execute(resource, method, parameters, "");
        }

        private String Execute(string resource, RestSharp.Method method, List<KeyValuePair<String, String>> parameters, String body)
        {
            var request = new RestRequest(resource, method);
            request.RequestFormat = DataFormat.Json;

            if(parameters != null)
            {
                foreach (KeyValuePair<String, String> parameter in parameters)
                {
                    request.AddUrlSegment(parameter.Key, parameter.Value);
                }
            }

            request.AddParameter("application/json; charset=utf8", body, ParameterType.RequestBody);
            IRestResponse response = Client.Execute(request);

            if (response.ErrorException != null)
            {
                Debug.WriteLine("API Error:");
                Debug.WriteLine(response.ErrorException.Message);
            }
            else
            {
                string content = response.Content;
                Debug.WriteLine(content);
                return content;
            }
            return "failed";
        }
    }
}
