using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Resources
{
    public interface IVersionResource
    {
        Models.Version.Version Get();
    }
}
