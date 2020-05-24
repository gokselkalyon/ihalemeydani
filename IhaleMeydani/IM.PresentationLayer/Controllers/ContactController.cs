using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        [Route("Contact")]
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactList()
        {
            return PartialView(IhaleServiceClient.GetContacts().ToList());
        }
        public PartialViewResult ContactAdd()
        {
            return PartialView(new ContactModelView());
        }
        [HttpPost]
        public JsonResult ContactAddOperation(Contact contact)
        {
            IhaleServiceClient.AddContact(contact);
            jsonResultModel.Icon = "success";
            jsonResultModel.Title = "Ekleme İşlemi";
            jsonResultModel.Modal = "ContactAddModal";
            jsonResultModel.Description = "İletişim Başarıyla Eklendi";

            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [Route("RemoveContact")]
        public JsonResult ContactRemove(int id)
        {
            IhaleServiceClient.RemoveContact(id);
            jsonResultModel.Icon = "success";
            jsonResultModel.Title = "Silme İşlemi";
            jsonResultModel.Description = "İletişim Başarıyla Silindi";

            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
    }
}