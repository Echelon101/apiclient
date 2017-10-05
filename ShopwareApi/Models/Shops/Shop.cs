using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopwareApi.Models.Shops
{
    public class Shop
    {
        public int id;
        public int mainId;
        public int categoryId;
        public string name;
        public string title;
        public string position;
        public string host;
        public string basePath;
        public string baseUrl;
        public string hosts;
        public bool secure;
        public bool alwaysSecure;
        public string secureHost;
        public string secureBasePath;
        public bool @default;
        public bool active;
        public bool customerScope;
        public Currency  currency = new Currency();
        
    }
}
