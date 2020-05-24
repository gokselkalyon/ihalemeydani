using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using I = IM.PresentationLayer.IhaleWCFService;

namespace IM.PresentationLayer.Controllers
{
    public class IconsController : BaseController
    {
        [Route("Icons")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("IconList")]
        public PartialViewResult List()
        {
            return PartialView(IhaleServiceClient.GetIcons().ToList());
        }
        public PartialViewResult Add()
        {
            return PartialView(new IconModelView());
        }
        [HttpPost]
        public JsonResult IconAddOperation(IconModelView icon)
        {
            IhaleServiceClient.AddIcon(new I.Icon
            {
                Name = icon.Name
            });

            jsonResultModel.Title = "Ekleme İşlemi";
            jsonResultModel.Icon = "success";
            jsonResultModel.Modal = "IconAddModal";
            jsonResultModel.Description = "İcon Başarıyla Eklendi";

            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
    }
}