using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi.Models.Configurators;
using ShopwareApi.Models.Articles;

namespace ShopwareApi.Models.Variants
{
    public class Variant
    {
        public int? id;
        public int articleId;
        public int unitId;
        public string number;
        public string supplierNumber;
        public int kind;
        public bool active;
        public int inStock;
        public int stockMin;
        public string weight;
        public string len;
        public string height;
        public string ean;
        public int position;
        public int minPurchase;
        public int purchaseSteps;
        public int maxPurchase;
        public string purchaseUnit;
        public bool shippingFree;
        public string releaseDate;
        public string shippingTime;
        public List<Price> prices;
        public Attributes.Attribute attribute = new Attributes.Attribute();
        public List<ConfiguratorOption> configuratorOptions;

        public string additionalText;
    }
}
