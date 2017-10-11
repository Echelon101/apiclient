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
                Console.WriteLine("Jump into Address Loop");
                foreach (ShopwareApi.Models.Adresses.Address address in addresses)
                {
                    Console.WriteLine(address.SerializeObjectJson<ShopwareApi.Models.Adresses.Address>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");

                ShopwareApi.Models.Articles.ArticleMain article = client.GetArticleResource().Get(5000);
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(article.SerializeObjectJson<ShopwareApi.Models.Articles.ArticleMain>());
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.Caches.Cache> caches = client.GetCacheResource().GetAll();
                Console.WriteLine("Jump into Cache Loop");
                foreach (ShopwareApi.Models.Caches.Cache cache in caches)
                {
                    Console.WriteLine(cache.SerializeObjectJson<ShopwareApi.Models.Caches.Cache>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");

                ShopwareApi.Models.Categories.Category category = client.GetCategoryResource().Get(22);
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine(category.SerializeObjectJson<ShopwareApi.Models.Categories.Category>());
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.Countries.Country> countrys = client.GetCountryResource().GetAll();
                Console.WriteLine("Jump into Country Loop");
                foreach (ShopwareApi.Models.Countries.Country country in countrys)
                {
                    Console.WriteLine(country.SerializeObjectJson<ShopwareApi.Models.Countries.Country>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.CustomerGroups.CustomerGroup> customerGroups = client.GetCustomerGroupResource().GetAll();
                Console.WriteLine("Jump into CustomerGroup Loop");
                foreach (ShopwareApi.Models.CustomerGroups.CustomerGroup customerGroup in customerGroups)
                {
                    Console.WriteLine(customerGroup.SerializeObjectJson<ShopwareApi.Models.CustomerGroups.CustomerGroup>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.Media.Media> medien = client.GetMediaResource().GetAll();
                Console.WriteLine("Jump into Media Loop");
                foreach (ShopwareApi.Models.Media.Media media in medien)
                {
                    Console.WriteLine(media.SerializeObjectJson<ShopwareApi.Models.Media.Media>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                
                //ShopwareApi.Models.Orders.Order order1 = client.GetOrderResource().Get(1); //TODO: FIX NullReferenceException
               
                
                List<ShopwareApi.Models.Properties.PropertyGroup> propertyGroups = client.GetPropertyGroupResource().GetAll();
                Console.WriteLine("Jump into propertyGroup Loop");
                foreach (ShopwareApi.Models.Properties.PropertyGroup propertyGroup in propertyGroups)
                {
                    Console.WriteLine(propertyGroup.SerializeObjectJson<ShopwareApi.Models.Properties.PropertyGroup>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.Shops.Shop> shops = client.GetShopResource().GetAll();
                Console.WriteLine("Jump into Shop Loop");
                foreach (ShopwareApi.Models.Shops.Shop shop in shops)
                {
                    Console.WriteLine(shop.SerializeObjectJson<ShopwareApi.Models.Shops.Shop>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.Manufacturers.Supplier> suppliers = client.GetSupplierResource().GetAll();
                Console.WriteLine("Jump into Supplier Loop");
                foreach (ShopwareApi.Models.Manufacturers.Supplier supplier in suppliers)
                {
                    Console.WriteLine(supplier.SerializeObjectJson<ShopwareApi.Models.Manufacturers.Supplier>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");

                List<ShopwareApi.Models.Variants.Variant> variants = client.GetVariantResource().GetAll();
                Console.WriteLine("Jump into Variant Loop");
                foreach (ShopwareApi.Models.Variants.Variant variant in variants)
                {
                    Console.WriteLine(variant.SerializeObjectJson<ShopwareApi.Models.Variants.Variant>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");

                ShopwareApi.Models.Version.Version version = client.GetVersionResource().Get();
                Console.WriteLine(version.SerializeObjectJson<ShopwareApi.Models.Version.Version>());




                List<ShopwareApi.Models.Orders.Order> orders = client.GetOrderResource().GetAll();
                Console.WriteLine("Jump into Order Loop");
                foreach (ShopwareApi.Models.Orders.Order order in orders)
                {
                    Console.WriteLine(order.SerializeObjectJson<ShopwareApi.Models.Orders.Order>());
                    Console.WriteLine("----------------------------------------------------------------");
                }
                Console.WriteLine("done");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("test");
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
