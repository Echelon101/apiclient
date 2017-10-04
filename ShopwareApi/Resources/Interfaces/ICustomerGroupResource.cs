using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.CustomerGroups;

namespace ShopwareApi.Resources
{
    public interface ICustomerGroupResource
    {
        List<CustomerGroup> GetAll();

        CustomerGroup Get(int id);

        CustomerGroup Get(string id);

        void Add(CustomerGroup customerGroup);

        void Update(CustomerGroup customerGroup);
    }
}
