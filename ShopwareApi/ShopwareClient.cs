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

        private ArticleResource articleResource; //implemented
        private CategoryResource categoryResource; //implemented
        private OrderResource orderResource; //implemented
        private CustomerResource customerResource; //implemented
        private VersionResource versionResource; //implemented
        private CacheResource cacheResource; //implemented
        private AddressResource addressResource; //implemented
        private CustomerGroupResource customerGroupResource; //implemented
        private GenerateArticleImage generateArticleImage; 
        private CountryResource countryResource; //implemented
        private MediaResource mediaResource; //implemented
        private SupplierResource supplierResource; //implemented

        public ShopwareClient(string url, string username, string apiKey)
        {
            this.url = url;
            this.username = username;
            this.apiKey = apiKey;

            this.client = new RestClient(url);
            client.Authenticator = new DigestAuthenticator(username, apiKey);
            client.UserAgent = "ShopwareApiClient v1.0";
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

        public VersionResource GetVersionResource()
        {
            if(this.versionResource == null)
            {
                this.versionResource = new VersionResource(this.client);
            }
            return this.versionResource;
        }

        public CacheResource GetCacheResource()
        {
            if(this.cacheResource == null)
            {
                this.cacheResource = new CacheResource(this.client);
            }
            return this.cacheResource;
        }

        public CustomerGroupResource GetCustomerGroupResource()
        {
            if (this.customerGroupResource == null)
            {
                this.customerGroupResource = new CustomerGroupResource(this.client);
            }
            return this.customerGroupResource;
        }

        public AddressResource GetAddressResource()
        {
            if(this.addressResource == null)
            {
                this.addressResource = new AddressResource(this.client);
            }
            return this.addressResource;
        }

        public MediaResource GetMediaResource()
        {
            if(this.mediaResource == null)
            {
                this.mediaResource = new MediaResource(this.client);
            }
            return this.mediaResource;
        }

        public CountryResource GetCountryResource()
        {
            if(this.countryResource == null)
            {
                this.countryResource = new CountryResource(this.client);
            }
            return this.countryResource;
        }

        public SupplierResource GetSupplierResource()
        {
            if(this.supplierResource == null)
            {
                this.supplierResource = new SupplierResource(this.client);
            }
            return this.supplierResource;
        }
    }

}
