using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient;
using ApiClient.Resources;
using ApiClient.Models.Articles;

namespace ShopwareApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ShopwareApi shopwareApi = new ShopwareApi("http://shop.localtest.me/api", "demo", "RCiG7xCeTwHm0IFnNDXtwi2OFZPR5tMmv2PqJi9q");

                for (int i = 1; i < 100; i++)
                {
                    ArticleMain article = shopwareApi.GetArticleResource().Get(i);
                    Console.WriteLine(article.name);
                    Console.WriteLine(article.id);
                }

                var articles = shopwareApi.GetArticleResource().GetAll();
                foreach (var articleN in articles)
                {
                    Console.WriteLine(articleN.name);
                    Console.WriteLine(articleN.id);
                }
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
