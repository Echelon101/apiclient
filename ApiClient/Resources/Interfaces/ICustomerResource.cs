using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Customers;

namespace ShopwareApi.Resources
{
    public interface ICustomerResource
    {
        List<Customer> GetAll();

        Customer Get(int id);

        Customer Get(string id);

        Customer GetByCustomerNumber(string customerNumber);

        void Add(Customer customer);

        void Update(Customer customer);


    }
}
