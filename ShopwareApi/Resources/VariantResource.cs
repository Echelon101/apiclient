using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Models.Variants;

namespace ShopwareApi.Resources
{
    public class VariantResource : SuperResource<Variant>, IVariantResource
    {
        public VariantResource (IRestClient client)
            : base (client)
        {
            resourceUrl = "variants";
        }

        // add require check for add and update
    }
}
