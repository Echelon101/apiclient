using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Properties;

namespace ShopwareApi.Resources
{
    public interface IPropertyGroupResource
    {
        List<PropertyGroup> GetAll();

        PropertyGroup Get(int id);

        PropertyGroup Get(string id);

        void Add(PropertyGroup propertyGroup);

        void Update(PropertyGroup propertyGroup);
    }
}
