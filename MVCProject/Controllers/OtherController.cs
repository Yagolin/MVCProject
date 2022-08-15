using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class OtherController : Controller
    {
        // GET: Other
        [ChildActionOnly]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Full_Width()
        {
            return View();
        }
        public ActionResult Sidebar()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}