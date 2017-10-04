using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Countries
{
    public class Country
    {
        public int id;
        public string name;
        public string iso;
        public string isoName;
        public int position;
        public string description;
        public bool shippingFree;
        public bool taxFree;
        public bool taxFreeUstIdChecked;
        public bool active;
        public string iso3;
        public bool displayStateInRegistration;
        public bool forceStateInRegistration;
        public int areaId;
        public List<State> states;
    }
}
