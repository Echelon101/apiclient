﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient.Models.Articles
{
    public class PropertyValue
    {
        public int id;
        public string value;
        public int position;
        public int optionId;
        public string valueNumeric;

        public int? mediaId;
    }
}