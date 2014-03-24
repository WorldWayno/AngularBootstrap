using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularBootstrap.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Book/
        [HttpGet]
        public ActionResult Bootstrap()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Angular()
        {
            return View();
        }
	}
}