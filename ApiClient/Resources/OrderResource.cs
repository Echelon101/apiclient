using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient.Models.Orders;
using RestSharp;

namespace ApiClient.Resources
{
    public class OrderResource : SuperResource<Order>, IOrderResource 
    {
        public OrderResource(IRestClient client)
            : base (client)
        {
            resourceUrl = "orders";
        }

        public void Add()
        {
            throw new NotImplementedException("It is not allowed to add orders via Shopware REST API.");
        }

        public void Delete()
        {
            throw new NotImplementedException("It is not allowed to delete orders via Shopware REST API.");
        }
    }
}
