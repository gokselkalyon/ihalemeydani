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
        public FirebaseStorageHelper firebaseStorageHelper = Singleton.GetfirebaseStorageHelperinstance();
        public JsonResultModel jsonResultModel = Singleton.GetjsonResultModelinstance();
        public IhaleServiceClient IhaleServiceClient = Singleton.GetIhaleinstance();
    }
}