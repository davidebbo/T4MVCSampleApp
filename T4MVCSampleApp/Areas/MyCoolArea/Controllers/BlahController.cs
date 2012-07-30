using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCSampleApp.Areas.MyCoolArea.Controllers
{
    public partial class BlahController : Controller
    {
        //
        // GET: /MyCoolArea/Blah/

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
