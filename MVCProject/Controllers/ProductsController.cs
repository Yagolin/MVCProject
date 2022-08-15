using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ProductCategoryModel model = new ProductCategoryModel
            {
                Products = Database.Products,
                Categories = Database.Categories,
                ProductCount = Database.Products.Count,
            };


            return View(model);
        }
    }
}