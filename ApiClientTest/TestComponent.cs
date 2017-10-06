using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi;
using ShopwareApi.Models.Shops;


namespace ApiClientTest
{
    class TestComponent
    {
        private string url;
        private string username;
        private string apiKey;
        private ShopwareClient client;

        public TestComponent(string url, string username, string apiKey)
        {
            this.url = url;
            this.username = username;
            this.apiKey = apiKey;

            this.client = new ShopwareClient(url, username, apiKey);
        }

        public Shop Shop(string id)
        {
            Shop shop = client.GetShopResource().Get(id);
            return shop;
        }
        public List<Shop> Shops()
        {
            return client.GetShopResource().GetAll();
        }
    }
}
