using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Adresses;

namespace ShopwareApi.Resources
{
    public interface IAddressResource
    {
        List<Address> GetAll();

        Address Get(int id);

        Address Get(string id);

        void Add(Address address);

        void Update(Address address);
    }
}
