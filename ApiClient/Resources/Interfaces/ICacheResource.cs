using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Caches;

namespace ShopwareApi.Resources
{
    public interface ICacheResource
    {
        List<Cache> GetAll();

        Cache Get(int id);

        Cache Get(string id);


    }
}
