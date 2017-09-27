using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient;

namespace ApiClientTests
{
    class ApiConnection
    {
        public static ShopwareApi GetShopwareApi()
        {
            ShopwareApi shopwareApi = new ShopwareApi("http://shop.localhost/api/", "demo", "RCiG7xCeTwHm0IFnNDXtwi2OFZPR5tMmv2PqJi9q");
            return shopwareApi;
        }
    }
}
