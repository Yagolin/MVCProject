using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class ProductCategoryModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public int ProductCount { get; set; }
    }
}