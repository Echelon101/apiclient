using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient;
using ApiClient.Resources;
using ApiClient.Models.Articles;

namespace ApiClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ShopwareApi shopwareApi = new ShopwareApi("http://shop.localtest.me/api", "demo", "RCiG7xCeTwHm0IFnNDXtwi2OFZPR5tMmv2PqJi9q");
                ArticleMain article = shopwareApi.GetArticleResource().Get(2);
                Console.WriteLine(article.name);
                Console.WriteLine(article.id);
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
