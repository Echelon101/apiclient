using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Orders;

namespace ShopwareApi.Resources
{
    public interface IOrderResource
    {
        List<Order> GetAll();

        Order Get(int id);

        Order Get(string id);

        void Update(Order order);
    }
}
