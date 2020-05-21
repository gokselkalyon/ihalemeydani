using IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class ClaimGroupController : Controller
    {
        // GET: ClaimGroup
        IhaleServiceClient ihaleClient = new IhaleServiceClient();
        public ActionResult Index()
        {
            var claimGroup = ihaleClient.GetClaimGroups();
            return View(claimGroup);
        }
    }
}