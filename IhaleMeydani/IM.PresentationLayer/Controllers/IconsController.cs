using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class IconsController : Controller
    {
        // GET: Icons
        [Route("Icons")]
        public ActionResult Index()
        {
            return View();
        }
    }
}