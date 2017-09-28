using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Authenticators;
using ShopwareApi.Resources;

namespace ShopwareApi
{
    public class ShopwareClient
    {
        private string url;
        private string username;
        private string apiKey;
        private RestClient client;

        private ArticleResource articleResource;
        private CategoryResource categoryResource;
        private OrderResource orderResource;
        private CustomerResource customerResource;

        public ShopwareClient(string url, string username, string apiKey)
        {
            this.url = url;
            this.username = username;
            this.apiKey = apiKey;

            this.client = new RestClient(url);
            client.Authenticator = new DigestAuthenticator(username, apiKey);
            
        }

        public ArticleResource GetArticleResource()
        {
            if(this.articleResource == null)
            {
                this.articleResource = new ArticleResource(this.client);
            }
            return this.articleResource;
        }

        public CategoryResource GetCategoryResource()
        {
            if(this.categoryResource == null)
            {
                this.categoryResource = new CategoryResource(this.client);
            }
            return this.categoryResource;
        }

        public OrderResource GetOrderResource()
        {
            if(this.categoryResource == null)
            {
                this.orderResource = new OrderResource(this.client);
            }
            return this.orderResource;
        }

        public CustomerResource GetCustomerResource()
        {
            if(this.customerResource == null)
            {
                this.customerResource = new CustomerResource(this.client);
            }
            return this.customerResource;
        }

    }

}
