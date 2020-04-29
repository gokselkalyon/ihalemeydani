using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class HomeController : BaseController
    {
        [Route("Anasayfa")]
        [Route("~/", Name = "default")]
        public ActionResult Index()
        {
            return View();
        }

        //Örnek firebase kodları

        [HttpPost]
        public async Task ImageConvertByte(HttpPostedFileBase file2)
        {
            if (file2 != null && file2.ContentLength > 0)
            {
                var _stream = file2.InputStream;
                var _name = Guid.NewGuid() + file2.FileName;
                Session["Image"] = _name;
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