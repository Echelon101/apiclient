using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Shops;

namespace ShopwareApi.Resources
{
    public interface IShopsResource
    {
        List<Shop> GetAll();

        Shop Get(int id);

        Shop Get(string id);

        void Add(Shop shop);

        void Update(Shop shop);
    }
}
