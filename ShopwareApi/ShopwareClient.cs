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

        private AddressResource addressResource; //implemented
        private ArticleResource articleResource; //implemented
        private CacheResource cacheResource; //implemented
        private CategoryResource categoryResource; //implemented
        private CountryResource countryResource; //implemented
        private CustomerGroupResource customerGroupResource; //implemented
        private CustomerResource customerResource; //implemented
        private GenerateArticleImage generateArticleImage;
        private MediaResource mediaResource; //implemented
        private OrderResource orderResource; //implemented
        private PropertyGroupResource propertyGroupResource; //implemented
        private ShopResource shopResource; //implemented
        private SupplierResource supplierResource; //implemented
        private TranslationResource translationResource;
        private VariantResource variantResource; //implemented
        private VersionResource versionResource; //implemented

        
        

        public ShopwareClient(string url, string username, string apiKey)
        {
            this.url = url;
            this.username = username;
            this.apiKey = apiKey;

            this.client = new RestClient(url);
            client.Authenticator = new DigestAuthenticator(username, apiKey);
            client.UserAgent = "ShopwareApiClient v1.0";
        }

        public AddressResource GetAddressResource()
        {
            if (this.addressResource == null)
            {
                this.addressResource = new AddressResource(this.client);
            }
            return this.addressResource;
        }

        public ArticleResource GetArticleResource()
        {
            if(this.articleResource == null)
            {
                this.articleResource = new ArticleResource(this.client);
            }
            return this.articleResource;
        }

        public CacheResource GetCacheResource()
        {
            if (this.cacheResource == null)
            {
                this.cacheResource = new CacheResource(this.client);
            }
            return this.cacheResource;
        }

        public CategoryResource GetCategoryResource()
        {
            if(this.categoryResource == null)
            {
                this.categoryResource = new CategoryResource(this.client);
            }
            return this.categoryResource;
        }

        public CountryResource GetCountryResource()
        {
            if (this.countryResource == null)
            {
                this.countryResource = new CountryResource(this.client);
            }
            return this.countryResource;
        }

        public CustomerGroupResource GetCustomerGroupResource()
        {
            if (this.customerGroupResource == null)
            {
                this.customerGroupResource = new CustomerGroupResource(this.client);
            }
            return this.customerGroupResource;
        }

        public CustomerResource GetCustomerResource()
        {
            if (this.customerResource == null)
            {
                this.customerResource = new CustomerResource(this.client);
            }
            return this.customerResource;
        }

        public MediaResource GetMediaResource()
        {
            if (this.mediaResource == null)
            {
                this.mediaResource = new MediaResource(this.client);
            }
            return this.mediaResource;
        }

        public OrderResource GetOrderResource()
        {
            if(this.categoryResource == null)
            {
                this.orderResource = new OrderResource(this.client);
            }
            return this.orderResource;
        }

        public PropertyGroupResource GetPropertyGroupResource()
        {
            if(this.propertyGroupResource == null)
            {
                this.propertyGroupResource = new PropertyGroupResource(this.client);
            }
            return this.propertyGroupResource;
        }

        public ShopResource GetShopResource()
        {
            if(this.shopResource == null)
            {
                this.shopResource = new ShopResource(this.client);
            }
            return this.shopResource;
        }

        public SupplierResource GetSupplierResource()
        {
            if (this.supplierResource == null)
            {
                this.supplierResource = new SupplierResource(this.client);
            }
            return this.supplierResource;
        }

        public VariantResource GetVariantResource()
        {
            if(this.variantResource == null)
            {
                this.variantResource = new VariantResource(this.client);
            }
            return this.variantResource;
        }

        public VersionResource GetVersionResource()
        {
            if (this.versionResource == null)
            {
                this.versionResource = new VersionResource(this.client);
            }
            return this.versionResource;
        }
    }

}
