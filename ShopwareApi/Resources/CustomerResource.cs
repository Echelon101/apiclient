using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Models.Customers;

namespace ShopwareApi.Resources
{
    public class CustomerResource : SuperResource<Customer>, ICustomerResource
    {
        public CustomerResource(IRestClient client)
            : base (client)
        {
            resourceUrl = "customers";
        }

        public Customer GetByCustomerNumber(string customerNumber)
        {
            return this.Get(customerNumber + "useNumberAsID=true");
        }
    }
}
