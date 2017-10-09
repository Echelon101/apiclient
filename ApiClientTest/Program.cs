using System;
using ShopwareApi;
using ShopwareApi.Serializers;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;


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

                List<ShopwareApi.Models.Adresses.Address> addresses = client.GetAddressResource().GetAll();
                ShopwareApi.Models.Articles.ArticleMain article = client.GetArticleResource().Get(25);
                List<ShopwareApi.Models.Caches.Cache> caches = client.GetCacheResource().GetAll();
                ShopwareApi.Models.Categories.Category category = client.GetCategoryResource().Get(22);
                List<ShopwareApi.Models.Countries.Country> country = client.GetCountryResource().GetAll();
                List<ShopwareApi.Models.CustomerGroups.CustomerGroup> customerGroups = client.GetCustomerGroupResource().GetAll();
                List<ShopwareApi.Models.Media.Media> media = client.GetMediaResource().GetAll();
                //ShopwareApi.Models.Orders.Order order1 = client.GetOrderResource().Get(1); //TODO: FIX NullReferenceException
                //List<ShopwareApi.Models.Orders.Order> orders = client.GetOrderResource().GetAll();
                List<ShopwareApi.Models.Properties.PropertyGroup> propertyGroups = client.GetPropertyGroupResource().GetAll();
                ShopwareApi.Models.Shops.Shop shop = client.GetShopResource().Get(2);
                List<ShopwareApi.Models.Manufacturers.Supplier> suppliers = client.GetSupplierResource().GetAll();
                List<ShopwareApi.Models.Variants.Variant> variants = client.GetVariantResource().GetAll();
                ShopwareApi.Models.Version.Version version = client.GetVersionResource().Get();

                Console.WriteLine("Jump into Address Loop");
                foreach (ShopwareApi.Models.Adresses.Address address in addresses)
                {
                    Console.WriteLine(address.SerializeObjectJson<ShopwareApi.Models.Adresses.Address>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(article.SerializeObjectJson<ShopwareApi.Models.Articles.ArticleMain>());
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Jump into Cache Loop");
                foreach (ShopwareApi.Models.Caches.Cache cache in caches)
                {
                    Console.WriteLine(cache.SerializeObjectJson<ShopwareApi.Models.Caches.Cache>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Jump into PropertyGroup Loop");
                foreach (ShopwareApi.Models.Properties.PropertyGroup propertyGroup in propertyGroups)
                {
                    Console.WriteLine(propertyGroup.SerializeObjectJson<ShopwareApi.Models.Properties.PropertyGroup>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(shop.SerializeObjectJson<ShopwareApi.Models.Shops.Shop>());
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Jump into Supplier Loop");
                foreach  (var supplier in suppliers)
                {
                    Console.WriteLine(supplier.SerializeObjectJson<ShopwareApi.Models.Manufacturers.Supplier>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Jump into Variant Loop");
                foreach (var variant in variants)
                {
                    Console.WriteLine(variant.SerializeObjectJson<ShopwareApi.Models.Variants.Variant>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(version.SerializeObjectJson<ShopwareApi.Models.Version.Version>());


                /*
                string json = client.GetArticleResource().GetJsonResponse(25);
                Console.WriteLine(json);


                StreamWriter streamWriter = new StreamWriter("JsonSW_OLD.json");
                streamWriter.WriteLine(json);
                */
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Debug.WriteLine(e);
                
            }
            Console.ReadKey();
        }

    }
}
