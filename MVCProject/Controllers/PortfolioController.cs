using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        [ChildActionOnly]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Column_1()
        {
            return View();
        }

        public ActionResult Column_2()
        {
            return View();
        }

        public ActionResult Column_3()
        {
            return View();
        }

        public ActionResult Single()
        {
            return View();
        }
    }
}