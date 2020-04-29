using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class BlogPostController : Controller
    {    
        [Route("Blog")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("BlogContent")]
        public ActionResult ContentIndex()
        {
            return View();
        }
    }
}