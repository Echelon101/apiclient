using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Manufacturers;

namespace ShopwareApi.Resources
{
    public interface ISupplierResource
    {
        List<Supplier> GetAll();

        Supplier Get(int id);

        Supplier Get(string id);

        void Add(Supplier supplier);

        void Update(Supplier supplier);
    }
}
