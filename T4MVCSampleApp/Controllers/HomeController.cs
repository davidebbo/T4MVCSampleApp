using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCSampleApp.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public virtual ActionResult About()
        {
            return View();
        }

        public virtual JsonResult ActionReturningJson()
        {
            throw new NotImplementedException();
        }

        [Route("My/Attrib/Route")]
        public virtual ActionResult TestAttribRoute()
        {
            return View();
        }
    }
}
