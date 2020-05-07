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
        [Route("hizlisatis")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("hizlisatisdetay")]
        public ActionResult Details()
        {
            return View();
        }
    }
}