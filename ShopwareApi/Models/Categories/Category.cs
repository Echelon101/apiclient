﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.CustomerGroups;

namespace ShopwareApi.Models.Categories
{
    public class Category
    {
        public int? id;
        public int parentId;
        public int? streamId;
        public string name;
        public int position;
        public string metaTitle;
        public string metaKeywords;
        public string metaDescription;
        public string cmsHeadline;
        public string cmdText;
        public bool active;
        public string template;
        public string productBoxLayout;
        public bool blog;
        public string path;
        public bool showFilterGroups;
        public string external;
        public bool hideFilter;
        public bool hideTop;
        public string changed;
        public string added;
        public int mediaId;
        public List<string> attribute;

        public List<Media.Media> emotions;
        public string media;

        public List<CustomerGroup> customerGroups;
        public int childrenCount;
        public int articleCount;
    }
}
