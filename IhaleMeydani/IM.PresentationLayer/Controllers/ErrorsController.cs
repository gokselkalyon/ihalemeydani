using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{

    public class ErrorsController : Controller
    {

        public ActionResult PageError(Exception exception = null)
        {
            if (exception != null)
            {
                Session["Exception"] = exception;
            }
            return View();
        }

        public ActionResult Error404(string aspxerrorpath)
        {
            Session["Source"] = null;

            if (!string.IsNullOrEmpty(aspxerrorpath))
                Session["Source"] = aspxerrorpath;

            Session["Title"] = "Sayfa Bulunamadı";

            Session["Url"] = "/Content/template/img/error-404-monochrome.svg";

            return RedirectToAction("PageError");
        }
        public ActionResult Error403(string aspxerrorpath)
        {
            Session["Source"] = null;

            if (!string.IsNullOrEmpty(aspxerrorpath))
                Session["Source"] = aspxerrorpath;

            Session["Title"] = "Sayfa Gizlenmiştir";

            Session["Url"] = "https://cdn.dribbble.com/users/516732/screenshots/4527062/dribbble-403.png";

            return View("PageError", null);
        }
        public ActionResult Error500(string aspxerrorpath)
        {
            Session["Source"] = null;

            if (!string.IsNullOrEmpty(aspxerrorpath))
                Session["Source"] = aspxerrorpath;

            Session["Title"] = "Sunucuda bir hata oluştu ve istek karşılanamadı.";

            Session["Url"] = "https://cdn1.iconfinder.com/data/icons/browser-5/100/ui-brower-go-25-512.png";

            return View("PageError", null);
        }
        public ActionResult Error401(string aspxerrorpath)
        {
            Session["Source"] = null;

            if (!string.IsNullOrEmpty(aspxerrorpath))
                Session["Source"] = aspxerrorpath;

            Session["Url"] = "https://cdn1.iconfinder.com/data/icons/website-internet-browser/711/401_error_unauthorized_internet_window_browser-512.png";

            Session["Title"] = "İstek için kimlik doğrulaması gerekiyor.";

            return View("PageError", null);
        }
        [Route("Hata")]
        public ActionResult CustomError()
        {
            Session["Source"] = "Özel bir hata meydana geldi yetkililer en kısa zamanda sorunu çözecektir";

            Session["Url"] = "https://lh3.googleusercontent.com/proxy/39ug6zrvJLzBlCzz78myctjjONdX9MaMSyaQJKKtsARHS2BHHanypNC8YIkUr5DXwZjSgQAIMHGPhOUdYaoAZLWpv7Sqsix4asQ653zBTGUC38XMF2Hl15fETA";

            Session["Title"] = "Hata";

            return View("PageError", null);
        }
        public ActionResult AuthorityError(string aspxerrorpath)
        {
            Session["Source"] = null;

            if (!string.IsNullOrEmpty(aspxerrorpath))
                Session["Source"] = aspxerrorpath;

            Session["Title"] = "Yetkiniz Bulunmamaktadır.";

            Session["Url"] = "/Content/template/assets/img/error-404-monochrome.svg";

            return RedirectToAction("PageError");
        }


        [Route("Errors/Error405")]
        public ActionResult Error405()
        {
            return View();
        }
        [Route("Errors/Error406")]
        public ActionResult Error406()
        {
            return View();
        }
        [Route("Errors/Error412")]
        public ActionResult Error412()
        {
            return View();
        }
       
        [Route("Errors/Error501")]
        public ActionResult Error501()
        {
            return View();
        }
        [Route("Errors/Error502")]
        public ActionResult Error502()
        {
            return View();
        }

    }
}