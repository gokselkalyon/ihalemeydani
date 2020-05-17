using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
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
            mv.Posts = IhaleServiceClient.QueryListPostModel().ToList();
            return View(mv);
        }
        [Route("BlogAdmin/Create")]
        public ActionResult AdminPanelCreate()
        {
            return View();
        }
        [HttpPost]
        [Route("BlogAdmin/Create")]
        public ActionResult AdminPanelCreate(PostModel postModel)
        {
            postModel.users_id = SessionManager.CurrentUser.Id;
            int değer = IhaleServiceClient.AddPostModel(postModel);
            return RedirectToAction("", "BlogAdmin");
        }
        [Route("BlogAdmin/Update")]
        public ActionResult AdminPanelUpdate()
        {
            return View();
        }
    }
}