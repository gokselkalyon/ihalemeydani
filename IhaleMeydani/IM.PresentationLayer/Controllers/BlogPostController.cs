using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            mv.Posts = IhaleServiceClient.QueryListPostModel().ToList();
            return View(mv);
        }
        [Route("Blog/Content/{id}")]
        public ActionResult BlogIndex(int id)
        {
            mv.Post = IhaleServiceClient.QueryListPostModel().Where(x => x.Post_id == id).FirstOrDefault();
            PostModel post = mv.Post;
            return View(post);
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
        [HttpGet]
        [Route("BlogAdmin/Update/{id}")]
        public ActionResult AdminPanelUpdate(int id)
        {
            mv.Post = IhaleServiceClient.QueryListPostModel().Where(x => x.Post_id == id).FirstOrDefault();
            PostModel post = mv.Post;
            return View(post);
        }
        [HttpPost]
        [Route("BlogAdmin/Update")]
        public ActionResult AdminPanelUpdate(PostModel postModel)
        {
            postModel.users_id = SessionManager.CurrentUser.Id;

            int değer = IhaleServiceClient.UpdataPostModel(postModel);
            return RedirectToAction("", "BlogAdmin");
        }

        [HttpPost]
        public async Task BlogImage(HttpPostedFileBase file2,PostModel postModel)
        {
            if (file2 != null && file2.ContentLength > 0)
            {
                var _stream = file2.InputStream;
                var _name = Guid.NewGuid() + file2.FileName;
                IhaleServiceClient.AddSubmitAsync(new submit { submit_article = postModel.submit_article });
                IhaleServiceClient.AddMediumAsync(new medium { image_name = postModel.image_name, image_path = _name, image_subtitle = postModel.image_subtitle, image_title = postModel.image_title });
                await firebaseStorageHelper.UploadFile(_stream, _name);
            }
        }
        [HttpPost]
        public async Task<JsonResult> GetFile()
        {
            var _value = (string)Session["Image"];

            return Json(await firebaseStorageHelper.GetFile(_value), JsonRequestBehavior.AllowGet);
        }
    }
}