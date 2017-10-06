using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Variants;

namespace ShopwareApi.Resources
{
    public interface IVariantResource
    {
        List<Variant> GetAll();

        Variant Get(int id);

        Variant Get(string id);

        void Add(Variant variant);

        void Update(Variant variant);
    }
}
