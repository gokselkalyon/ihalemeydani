using IM.BusinessLayer.Firebase;
using IM.PresentationLayer.Helper;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class BaseController : Controller
    {
        protected List<SelectListItem> SelectListItems = new List<SelectListItem>();
        protected FirebaseStorageHelper firebaseStorageHelper = Singleton.GetfirebaseStorageHelperinstance();
        protected JsonResultModel jsonResultModel = Singleton.GetjsonResultModelinstance();
        protected IhaleServiceClient IhaleServiceClient = Singleton.GetIhaleinstance();
    }
}