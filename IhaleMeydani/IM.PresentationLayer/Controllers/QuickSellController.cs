using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class QuickSellController : Controller
    {
        // GET: QuickSell
        public ActionResult Index()
        {
            return View();
        }

        [Route("hizlisatis")]
        public ActionResult Details()
        {
            return View();
        }
    }
}