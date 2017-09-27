using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ApiClient.Models.Orders;

namespace ApiClient.Resources
{
    public class CustomerResource : SuperResource<Order>
    {
        public CustomerResource(IRestClient client)
            : base (client)
        {
            resourceUrl = "customers";
        }
    }
}
