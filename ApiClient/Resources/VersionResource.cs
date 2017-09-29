using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace ShopwareApi.Resources
{
    public class VersionResource : SuperResource<Models.Version.Version>, IVersionResource
    {
        public VersionResource(IRestClient client)
            : base(client)
        {
            resourceUrl = "version";
        }

        public void Add()
        {
            throw new NotImplementedException("It is not allowed to add version via Shopware REST API.");
        }

        public void Update()
        {
            throw new NotImplementedException("It is not allowed to update version via Shopware REST API.");
        }

        public void Delete()
        {
            throw new NotImplementedException("It is not allowed to delete version via Shopware REST API.");
        }
    }
}
