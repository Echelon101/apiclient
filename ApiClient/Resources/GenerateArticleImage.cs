using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using ShopwareApi.Models.GenerateArticleImages;

namespace ShopwareApi.Resources
{
    public class GenerateArticleImage : SuperResource<GenerateArticleImageModel>, IGenerateArticleImage
    {
        public GenerateArticleImage(IRestClient client)
            : base (client)
        {
            resourceUrl = "generateArticleImages";
        }
        new public void GetAll()
        {
            throw new NotImplementedException("This action cannot be executed via Shopware REST API");
        }

        public void Add()
        {
            throw new NotImplementedException("This action cannot be executed via Shopware REST API");
        }

        public void Update()
        {
            throw new NotImplementedException("This action cannot be executed via Shopware REST API");
        }

        public void Delete()
        {
            throw new NotImplementedException("This action cannot be executed via Shopware REST API");
        }

        public GenerateArticleImageModel GetByArticleNumber(string articleNumber)
        {
            return this.Get(articleNumber + "?useNumberAsID=true");
        }
    }
}
