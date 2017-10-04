using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Manufacturers;
using RestSharp;

namespace ShopwareApi.Resources
{
    public class SupplierResource : SuperResource<Supplier>, ISupplierResource
    {
        public SupplierResource (IRestClient client)
            : base (client)
        {
            resourceUrl = "manufacturers";
        }

        new public void Add(Supplier supplier)
        {
            if(supplier.name != null)
            {
                base.Add(supplier);
                return;
            }
            throw new Exception("Minimum required fields for supplier add: supplier.name");
        }

        new public void Update(Supplier supplier)
        {
            if(supplier.id != null 
                && supplier.name != null)
            {
                base.ExecuteUpdate(supplier, supplier.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for supplier update: supplier.name, supplier.id");
        }
    }
}
