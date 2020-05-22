using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
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
        [ihaleClientFilter("ClaimGroup.Liste")]
        public ActionResult Index()
        {
            var claimGroup = ihaleClient.GetClaimGroups();
            return View(claimGroup);
        }
        [ihaleClientFilter("ClaimGroup.Ekle")]
        public ActionResult AddClaimGroup()
        { 
            return View();
        }
        [ihaleClientFilter("ClaimGroup.Ekle")]
        public ActionResult ClaimGroupAdd(ClaimGroupModelView cgmv)
        {
            ClaimGroup cg = new ClaimGroup();
            cg.Name = cgmv.ClaimGroupName;
            ihaleClient.AddClaimGroup(cg);
            return RedirectToAction("index");
        }
        [ihaleClientFilter("ClaimGroup.Sil")]
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
        [ihaleClientFilter("ClaimGroup.Güncelle")]
        [Route("ClaimGroup/Update/{Id}")]
        public ActionResult UpdateClaimGroup(int id)
        {
            var query = (from r in ihaleClient.GetClaimGroups()
                         where r.Id == id
                         select new ClaimGroupModelView
                         {
                             Id = r.Id,
                             ClaimGroupName = r.Name
                         }).FirstOrDefault();
            return View(query);
        }
        [ihaleClientFilter("ClaimGroup.Güncelle")]
        public ActionResult ClaimGroupUpdate(ClaimGroupModelView cgmv)
        {
            var query = ihaleClient.GetClaimGroup(cgmv.Id);
            query.Name = cgmv.ClaimGroupName;
            ihaleClient.UpdateClaimGroup(query);
            return RedirectToAction("index");
        }
    }
}