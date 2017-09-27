using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient.Models.Orders;

namespace ApiClient.Resources
{
    public interface IOrderResource
    {
        List<Order> GetAll();

        Order Get(int id);

        Order Get(string id);

        void Update(Order order);
    }
}
