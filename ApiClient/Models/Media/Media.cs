using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Media
{
    public class Media
    {
        public int? id;
        public int? albumId;
        public int? album;
        public string name;
        public string description;
        public string file;
        public string path;
        public string type;
        public string extension;
        public int? userId;
        public string created;
        public int? fileSize;
    }
}
