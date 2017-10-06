using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Properties
{
    public class PropertyGroup
    {
        public int? id;
        public string name;
        public int position;
        public bool comparable;
        public int sortMode;
        public List<PropertyGroupOption> options;
        public List<PropertyGroupAttribute> attribute;
    }
}
