using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class BlogPostController : Controller
    {
        IhaleServiceClient Db = new IhaleServiceClient();
        BlogModelView bm = new BlogModelView();
        [Route("Blog")]
        public ActionResult Index()
        {
            bm.Posts = Db.GetPosts().ToList();
            return View(bm);
        }
        [Route("BlogContent")]
        public ActionResult BlogIndex()
        {
            return View();
        }
    }
}