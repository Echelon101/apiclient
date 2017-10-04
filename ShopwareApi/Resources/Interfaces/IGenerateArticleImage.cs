using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.GenerateArticleImages;

namespace ShopwareApi.Resources
{
    public interface IGenerateArticleImage
    {
        GenerateArticleImageModel Get(int id);

        GenerateArticleImageModel Get(string id);

        GenerateArticleImageModel GetByArticleNumber(string articleNumber);
    }
}
