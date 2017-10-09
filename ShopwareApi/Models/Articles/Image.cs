using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Articles
{
    public class Image
    {
        public int? id;
        public int? articleId;
        public int? articleDetailsId;
        public string descripion;
        public string path;
        public int? main;
        public int? position;
        public int? width;
        public int? height;
        public string relations;
        public string extension;
        public int? parentId;
        public int? mediaId;
    }
}
