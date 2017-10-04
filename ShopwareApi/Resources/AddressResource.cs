using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Models.Adresses;

namespace ShopwareApi.Resources
{
    public class AddressResource : SuperResource<Address>, IAddressResource
    {
        public AddressResource(IRestClient client)
            : base (client)
        {
            resourceUrl = "addresses";
        }

        new public void Add(Address address)
        {
            if (address.customer != null
                && address.salutation != null
                && address.firstname != null
                && address.lastname != null
                && address.street != null
                && address.zipcode != null
                && address.city != null
                && address.country != null)
            {
                base.Add(address);
                return;
            }
            throw new Exception("Minimum required fields for address add: address.customer, address.salutation, address.firstname, address.lastname, address.street, address.zipcode, address.city, address.country");
        }

        new public void Update(Address address)
        {
            if (address.id != null)
            {
                base.ExecuteUpdate(address, address.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for address update: address.id");
        }
    }
}
