using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Categories;
using RestSharp;
using System.Diagnostics;

namespace ShopwareApi.Resources
{
    public class CategoryResource : SuperResource<Category>, ICategoryResource
    {
        public CategoryResource (IRestClient client)
            : base (client)
        {
            resourceUrl = "categories";
        }

        new public List<Category> GetAll()
        {
            ApiRequest request = new ApiRequest(this.resourceUrl, Method.GET);
            ApiRequestExecutor executor = new ApiRequestExecutor();

            ApiResponse<List<Category>> response = executor.Execute<List<Category>>(Client, request);

            Debug.WriteLine("New Method used!");

            return response.data;
        }

        new public void Add(Category category)
        {
            if(category.name != null)
            {
                base.Add(category);
                return;
            }
            throw new Exception("Minimum required fields for category add: category.name");
        } 

        new public void Update(Category category)
        {
            if(category.id != null && category.name != null)
            {
                base.ExecuteUpdate(category, category.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for article update: category.id, category.name");
        }

        public void Delete(int id)
        {
            base.Delete(id.ToString());
        }
    }
}
