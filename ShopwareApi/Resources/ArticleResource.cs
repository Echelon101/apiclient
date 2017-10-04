using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Articles;
using RestSharp;

namespace ShopwareApi.Resources
{
    public class ArticleResource : SuperResource<ArticleMain>, IArticleResource
    {
        public ArticleResource(IRestClient client)
            : base(client)
        {
            resourceUrl = "articles";
        }

        new public void Add(ArticleMain article)
        {
            if(article.name != null
                && article.mainDetail.number != null
                && article.supplier != null
                && article.tax.tax != null)
            {
                base.Add(article);
                return;
            }
            throw new Exception("Minimum required fields for article add: article.name, article.mainDetail.number, article.supplier. article.tax.tax");
        }

        new public void Update(ArticleMain article)
        {
            if(article.id != null)
            {
                if(article.mainDetail.configuratorOptions.Count == 0)
                {
                    article.mainDetail.configuratorOptions = null;
                }
                base.ExecuteUpdate(article, article.id.ToString());
                return;
            }
            throw new Exception("Minimum required fields for article update: article.id, article.name, article.mainDetail.number, article.supplier.name, article.tax.tax");
        }


        /// <summary>
        /// With this function it is possible to request an article by ordernumber
        /// </summary>
        /// <param name="ordernumber"></param>
        /// <returns></returns>
        public ArticleMain GetByOrdernumber(string ordernumber)
        {
            return this.Get(ordernumber + "?useNumberAsID=true");
        }
    }
}
