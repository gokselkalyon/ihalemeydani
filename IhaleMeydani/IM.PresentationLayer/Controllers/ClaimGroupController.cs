using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class ClaimGroupController : BaseController
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
        public JsonResult ClaimGroupDelete(int id)
        {
            try
            {
                ihaleClient.RemoveClaimGroup(id); 
            }
            catch (Exception)
            {
                jsonResultModel.Title = "Başarısız";
                jsonResultModel.Icon = "error";
                jsonResultModel.Description = "Role Ekleme Başarısız";
                return Json(0, JsonRequestBehavior.AllowGet);
            }
            return Json(1, JsonRequestBehavior.AllowGet);
        }
    }
}