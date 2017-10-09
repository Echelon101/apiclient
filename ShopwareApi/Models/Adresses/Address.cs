using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Adresses
{
    public class Address
    {
        public int? id;
        public int? customer;
        public string company;
        public string department;
        public string salutation;
        public string firstname;
        public string lastname;
        public string street;
        public string zipcode;
        public string city;
        public string phone;
        public string vatId;
        public string additionalAddressLine1;
        public string additionalAddressLine2;
        public int? country;
        public int? state;
        //public List<string> attribute; // TODO add correct type
    }
}
