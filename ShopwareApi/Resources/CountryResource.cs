using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Models.Countries;

namespace ShopwareApi.Resources
{
    public class CountryResource : SuperResource<Country>, ICountryResource
    {
        public CountryResource (IRestClient client)
            : base (client)
        {
            resourceUrl = "countries";
        }
    }
}
