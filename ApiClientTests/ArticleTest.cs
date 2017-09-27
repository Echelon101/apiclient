using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiClient;
using ApiClient.Models.Articles;
using ApiClient.Resources;
using System.Collections.Generic;

namespace ApiClient.Tests
{
    [TestClass()]
    public class ArticleTest
    {
        [TestMethod()]
        public void GetArticleResourceTest()
        {
            Assert.Fail();
        }
    }
}

namespace ApiClientTests
{
    [TestClass]
    public class ArticleTest
    {
        [TestMethod]
        public void GetArticleById()
        {
            ShopwareApi shopwareApi = ApiConnection.GetShopwareApi();
            ArticleMain article = shopwareApi.GetArticleResource().Get(1);

            Console.WriteLine("Article: {0}", article.name);
            Console.WriteLine("- ID: {0}", article.id);
        }
    }
}
