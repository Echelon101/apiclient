using ShopwareApi.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.CustomerGroups
{
    public class CustomerGroup
    {
        public int id;
        public string key;
        public string name;
        public bool tax;
        public bool taxInput;
        public bool mode;
        public int discount;
        public int minimumOrder;
        public int minimumOrderSurcharge;
        public List<Discount> discounts; //TODO add correct Type
    }
}
