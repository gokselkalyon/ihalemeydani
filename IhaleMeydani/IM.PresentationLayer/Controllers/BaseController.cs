using IM.BusinessLayer.Firebase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class BaseController : Controller
    {
        public FirebaseStorageHelper firebaseStorageHelper = new FirebaseStorageHelper("ihale-meydan.appspot.com");
    }
}