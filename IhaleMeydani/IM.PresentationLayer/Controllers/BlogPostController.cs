using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        //[HttpPost]
        //public ActionResult Yeni(PostModel PostModel)
        //{
        //    //eğer dosya gelmişse işlemleri yap
        //    if (Request.Files.Count > 0)
        //    {
        //        //Guid nesnesini benzersiz dosya adı oluşturmak için tanımladık ve Replace ile aradaki “-” işaretini atıp yan yana yazma işlemi yaptık.
        //        string DosyaAdi = Guid.NewGuid().ToString().Replace(“-“, “”);
        //        //Kaydetceğimiz resmin uzantısını aldık.
        //        string uzanti = System.IO.Path.GetExtension(Request.Files[0].FileName);
        //        string TamYolYeri = “~/IM.PresentationLayer\Content\Images\BlogImages\” +DosyaAdi + uzanti;
        //        //Eklediğimiz Resni Server.MapPath methodu ile Dosya Adıyla birlikte kaydettik.
        //        Request.Files[0].SaveAs(Server.MapPath(TamYolYeri));
        //        //Ve veritabanına kayıt için dosya adımızı değişkene aktarıyoruz.
        //        PostModel.image_path = DosyaAdi + uzanti;
        //    }
        //    mv.Post.Add(PostModel);
        //    mv.SaveChanges();
        //    return View();
        //}
        [HttpPost]
        public ActionResult ImageUpload(HttpPostedFileBase uploadfile)
        {
            if (uploadfile.ContentLength > 0)
            {
                string filePath = Path.Combine(Server.MapPath("~/Content/images"), Guid.NewGuid().ToString() + "_" + System.IO.Path.GetFileName(uploadfile.FileName));
                uploadfile.SaveAs(filePath);
            }

            return View();
        }
    }
}