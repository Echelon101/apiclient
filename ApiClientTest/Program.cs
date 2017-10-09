using System;
using ShopwareApi;
using YamlDotNet.Serialization;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;
using ShopwareApi.Models.Shops;

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
                ShopwareClient client = new ShopwareClient(url, username, apiKey);

                Shop shop = client.GetShopResource().Get(2);
                Console.WriteLine(shop.name);
                Console.WriteLine(shop.@default);
                Console.WriteLine(shop.host);
                Console.WriteLine("----------------------------------------------------");
                string response = shop.SerializeObjectJson<Shop>();
                Console.WriteLine(response);
                Console.WriteLine("----------------------------------------------------");
                string jsonResponse = client.GetShopResource().GetJsonResponse(2);
                Console.WriteLine(jsonResponse);

                /*
                string json = client.GetArticleResource().GetJsonResponse(25);
                Console.WriteLine(json);


                StreamWriter streamWriter = new StreamWriter("JsonSW_OLD.json");
                streamWriter.WriteLine(json);
                */
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Debug.WriteLine(e);
            }
            Console.ReadKey();
        }

    }

    public static class Serializer
    {
        public static string SerializeObjectXml<T>(this T toSerialize)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static string SerializeObjectJson<T>(this T toSerialize)
        {
            JsonSerializer jsonSerializer = new JsonSerializer();

            using (StringWriter textWriter = new StringWriter())
            {
                jsonSerializer.Serialize(textWriter, toSerialize);
                return textWriter.ToString();
            }
        }

        public static string  SerializeObjectYaml<T>(this T toSerialize)
        {
            var yamlSerializer = new SerializerBuilder().Build();

            return yamlSerializer.Serialize(toSerialize);
        }
    }
}
