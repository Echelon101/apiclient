using System;
using System.Collections.Generic;
using ShopwareApi.Models.Articles;

namespace ShopwareApi.Resources
{
    public interface IArticleResource
    {
        List<ArticleMain> GetAll();

        ArticleMain Get(int id);

        ArticleMain Get(string id);

        ArticleMain GetByOrdernumber(string ordernumber);

        void Add(ArticleMain article);

        void Update(ArticleMain article);
    }
}
