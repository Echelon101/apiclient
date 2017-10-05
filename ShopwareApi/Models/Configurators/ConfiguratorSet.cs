using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Configurators
{
    public class ConfiguratorSet
    {
        public int id;
        public string name;
        public bool @public;
        public int type;
        public ConfiguratorGroup groups = new ConfiguratorGroup();
    }
}
