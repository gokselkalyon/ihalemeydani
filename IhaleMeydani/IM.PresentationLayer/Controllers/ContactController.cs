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
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ContactList()
        {
            return PartialView(IhaleServiceClient.GetContacts());
        }
        public PartialViewResult ContactAdd()
        {
            return PartialView() 
        }

    }
}