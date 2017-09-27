using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using ApiClient.Resources;

namespace ApiClient
{
    public class ShopwareApi
    {
        private string url;
        private string username;
        private string apiKey;
        private RestClient client;

        private ArticleResource articleResource;
        private CategoryResource categoryResource;
        private OrderResource orderResource;

        public ShopwareApi(string url, string username, string apiKey)
        {
            this.url = url;
            this.username = username;
            this.apiKey = apiKey;

            this.client = new RestClient(url);
            client.Authenticator = new HttpBasicAuthenticator(username, apiKey);
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
    }
}
