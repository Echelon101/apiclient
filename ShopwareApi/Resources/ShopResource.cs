using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Shops;
using RestSharp;
namespace ShopwareApi.Resources
{
    public class ShopResource : SuperResource<Shop>, IShopsResource
    {
        public ShopResource (IRestClient client)
            : base (client)
        {
            resourceUrl = "shops";
        }

        new public void Add(Shop shop)
        {
            if (shop.name != null
                && shop.categoryId != null
                && shop.localeId != null
                && shop.currencyId != null
                && shop.customerGroupId != null)
            {
                base.Add(shop);
                return;
            }
            throw new Exception("Minimum required fields for shop add: shop.name, shop.categoryId, shop.localeId, shop.currencyId, shop.customerGroupId");
        }

        new public void Update(Shop shop)
        {
            if(shop.id != null)
            {
                base.ExecuteUpdate(shop, shop.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for shop update: shop.id");
        }
    }
}
