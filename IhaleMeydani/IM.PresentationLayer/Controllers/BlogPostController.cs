using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class BlogPostController : BaseController
    {

        BlogModelView mv = new BlogModelView();
        [Route("Blog")]
        public ActionResult Index()
        {        
            //IhaleServiceClient.AddPost();
            return View();
        }
        [Route("BlogContent")]
        public ActionResult BlogIndex()
        {
            return View();
        }

        [Route("BlogAdmin")]
        public ActionResult AdminPanel()
        {
            mv.Posts=IhaleServiceClient.
            return View();
        }
        [Route("BlogAdminCreate")]
        public ActionResult AdminPanelCreate()
        {
            return View();
        }
        [Route("BlogAdminUpdate")]
        public ActionResult AdminPanelUpdate()
        {
            return View();
        }
    }
}