using System;
using System.Collections.Generic;
using System.Text;

namespace LQExtension.Model
{
    public partial class EC_Product
    {
        public List<EC_ProductCombination> ProductCombinations { get; set; }
        public List<EC_ProductProperty> ProductProperties { get; set; }
        public List<EC_ProductBox> ProductBoxes { get; set; }
        public List<EC_ProductCustomCategory> ProductCustomCategories { get; set; }


    }
}
