using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiClient.Models.Articles;
using ApiClient.Models.Categories;
using ApiClient.Models.Translations;

namespace ApiClient.Models.Articles
{
    public class ArticleMain
    {
        public int? id;
        public int? mainDetailId;
        public int? taxId;
        public int? priceGroupId;
        public int? filterGroupId;
        public int? configuratorSetId;

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
        public PropertyGroup propertyGroup;
        public List<CustomerGroup> customerGroups;

        public List<Image> images;
        public string configuratorSet;
        public List<Link> links;

        public List<Download> downloads;

        public List<ArticleDetail> details;
        public List<SeoCategories> seoCategories;
        public List<Category> categories;
        public List<SimilarArticle> similar;
        public List<RelatedArticles> related;
        public List<Translation> translations;



    }
}
