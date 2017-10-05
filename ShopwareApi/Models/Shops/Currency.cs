using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Shops
{
    public class Currency
    {
        public int id;
        public string currency;
        public string name;
        public bool @default;
        public double factor;
        public string symbol;
        public int symbolPosition;
        public int position;
    }
}
