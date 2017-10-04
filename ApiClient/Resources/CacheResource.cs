using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Models.Caches;

namespace ShopwareApi.Resources
{
    public class CacheResource : SuperResource<Cache>, ICacheResource
    {
        public CacheResource(IRestClient client)
            : base (client)
        {
            resourceUrl = "caches";
        }

        public void Add()
        {
            throw new NotImplementedException("It is not allowed to add caches via Shopware REST API.");
        }

        public void Update()
        {
            throw new NotImplementedException("It is not allowed to update caches via Shopware REST API.");
        }
    }
}
