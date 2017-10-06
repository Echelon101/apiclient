using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Properties;
using RestSharp;

namespace ShopwareApi.Resources
{
    public class PropertyGroupResource : SuperResource<PropertyGroup>, IPropertyGroupResource
    {
        public PropertyGroupResource (IRestClient client)
            : base (client)
        {
            resourceUrl = "propertyGroups";
        }

        new public void Update(PropertyGroup propertyGroup)
        {
            if(propertyGroup.id != null)
            {
                base.ExecuteUpdate(propertyGroup, propertyGroup.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for propertyGroup update: propertyGroup.id");
        }

        //check requirements for add
    }
}
