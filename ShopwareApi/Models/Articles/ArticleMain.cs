using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Articles;
using ShopwareApi.Models.Categories;
using ShopwareApi.Models.Manufacturers;
using ShopwareApi.Models.CustomerGroups;
using ShopwareApi.Models.Configurators;
using ShopwareApi.Models.Taxes;
using ShopwareApi.Models.Properties;

namespace ShopwareApi.Models.Articles
{
    public class ArticleMain
    {
        public int? id;
        public int? mainDetailId;
        public int? taxId;
        public int? priceGroupId;
        public int? filterGroupId;
        public int? configuratorSetId;
        public int? supplierId;

        public string name;
        public string description;
        public string descriptionLong;

        public string added;
        public bool active;
        public int pseudoSales;

        public bool highlight;
        public string keywords;
        public string metaTitle;

        public string changed;
        public bool priceGroupActive;
        public bool lastStock;

        public int crossBundleLook;
        public bool notification;
        public string template;

        public int mode;
        public string availableFrom;
        public string availableTo;

        public ArticleMainDetail mainDetail = new ArticleMainDetail();
        public Supplier supplier = new Supplier();
        public Tax tax = new Tax();

        public List<PropertyValue> propertyValues;
        public PropertyGroup propertyGroup = new PropertyGroup();
        public List<CustomerGroup> customerGroups;

        public List<Image> images;
        public ConfiguratorSet configuratorSet = new ConfiguratorSet();
        public List<Link> links;

        public List<Download> downloads;

        public List<ArticleDetail> details;
        //public List<SeoCategories> seoCategories;
        public List<Category> categories;
        public List<SimilarArticle> similar;
        public List<RelatedArticles> related;
        public List<Translation> translations;
    }
}
