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
                ShopwareClient client = new ShopwareClient(url, username, apiKey);

                ArticleMain article = client.GetArticleResource().Get(5000);

                Console.WriteLine(article.name);
                Console.WriteLine(article.mainDetail.number);
                Console.WriteLine(article.mainDetail.prices[0].price);
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
