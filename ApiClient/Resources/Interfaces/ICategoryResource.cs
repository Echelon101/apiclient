using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient.Models.Categories;

namespace ApiClient.Resources
{
    public interface ICategoryResource
    {
        List<Category> GetAll();

        Category Get(int id);

        Category Get(string id);

        void Add(Category category);

        void Update(Category category);

        void Delete(int id);
    }
}
