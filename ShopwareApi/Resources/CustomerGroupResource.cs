using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.CustomerGroups;
using RestSharp;

namespace ShopwareApi.Resources
{
    public class CustomerGroupResource : SuperResource<CustomerGroup>, ICustomerGroupResource
    {
        public CustomerGroupResource(IRestClient client)
            : base (client)
        {
            resourceUrl = "customerGroups";
        }
    }
}
