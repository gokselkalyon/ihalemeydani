using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class ClaimGroupController : Controller
    {
        ClaimGroupModelView cgmv = new ClaimGroupModelView();
        // GET: ClaimGroup
        IhaleServiceClient ihaleClient = new IhaleServiceClient();
        public ActionResult Index()
        {
            var claimGroup = ihaleClient.GetClaimGroups();
            return View(claimGroup);
        }
        public ActionResult AddClaimGroup()
        { 
            return View();
        }
        public ActionResult ClaimGroupAdd(ClaimGroupModelView cgmv)
        {
            ClaimGroup cg = new ClaimGroup();
            cg.Name = cgmv.ClaimGroupName;
            ihaleClient.AddClaimGroup(cg);
            return RedirectToAction("index");
        }
    }
}