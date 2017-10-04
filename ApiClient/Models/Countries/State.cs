using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Countries
{
    public class State
    {
        public int id;
        public int countryId;
        public int position;
        public string name;
        public string shortCode;
        public bool active;
    }
}
