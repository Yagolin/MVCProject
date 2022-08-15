using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public static class Database
    {
        private static List<Product> _products;
        private static List<Category> _categories;

        static Database()
        {
            _products = new List<Product>()
            {
                new Product(){ProductId = 1, ProductName = "Monster Abra A5", Description = "PC1",Price = 15000,IsSouldOut=true},
                new Product(){ProductId = 2, ProductName = "Monster Abra A7", Description = "PC2",Price = 18000,IsSouldOut=false},
                new Product(){ProductId = 3, ProductName = "Monster Tulpar T5", Description = "PC3",Price = 21000,IsSouldOut=false},
                new Product(){ProductId = 4, ProductName = "Monster Tulpar T7", Description = "PC4",Price = 26000,IsSouldOut=false},
                new Product(){ProductId = 5, ProductName = "Monster Semruk S7", Description = "PC5",Price = 33000,IsSouldOut=false},
            };

            _categories = new List<Category>()
            {
                new Category(){CategoryId = 1 , CategoryName = "Monster Abra"},
                new Category(){CategoryId = 2 , CategoryName = "Monster Tulpar"},
                new Category(){CategoryId = 3 , CategoryName = "Monster Semruk"},
            };
        }

        public static List<Product> Products
        {
            get { return _products; }
        }

        public static List<Category> Categories 
        { 
            get { return _categories; } 
        }
    }
}

