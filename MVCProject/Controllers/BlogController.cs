using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        [ChildActionOnly]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Blog_Home()
        {
            return View();
        }
        public ActionResult Blog_Post()
        {
            return View();
        }
    }
}