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
    public class ClaimController : BaseController
    {
       
        IhaleServiceClient ihaleClient = new IhaleServiceClient();
        [ihaleClientFilter("Claim.Liste")]
        public ActionResult Index()
        {
            var claimGroup = ihaleClient.GetClaims(); 
            return View(claimGroup);
        }
        [ihaleClientFilter("Claim.Ekle")]
        public ActionResult AddClaim()
        {
            ClaimModelView cmv = new ClaimModelView();
            var query = ihaleClient.GetClaimGroups().Select(f => new ClaimModel { ClaimGroupName = f.Name }).ToList();
            cmv.claimGroupList = query;
            return View(cmv);
        }
        [ihaleClientFilter("Claim.Ekle")]
        public ActionResult ClaimAdd(ClaimModelView cmv)
        {
            var claimGroup = ihaleClient.GetClaimGroups().FirstOrDefault(f => f.Name == cmv.claimModel.ClaimGroupName);
            Claim c = new Claim();
            c.Text = cmv.claimModel.Text;
            c.ClaimGroupId = claimGroup.Id;
            ihaleClient.AddClaim(c);
            return RedirectToAction("index");
        }
        [ihaleClientFilter("Claim.Sil")]
        public JsonResult ClaimDelete(int id)
        {
            try
            {
                ihaleClient.RemoveClaim(id);
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
        [ihaleClientFilter("Claim.Güncelle")]
        [Route("Claim/Update/{Id}")]
        public ActionResult UpdateClaim(int id)
        {
            ClaimModelView cmv = new ClaimModelView();
            var claimGroupList = ihaleClient.GetClaimGroups().Select(f => new ClaimModel { ClaimGroupName = f.Name }).ToList();
    
            var query = (from r in ihaleClient.GetClaims()
                         join claimGroup in ihaleClient.GetClaimGroups() on r.ClaimGroupId equals claimGroup.Id
                         where r.Id == id
                         select new ClaimModel
                         {
                             Id = r.Id, 
                             Text = r.Text,
                             ClaimGroupName = claimGroup.Name
                         }).FirstOrDefault();
            cmv.claimGroupList = claimGroupList;
            cmv.claimModel = query;
            return View(cmv);
        }
        [ihaleClientFilter("Claim.Güncelle")]
        public ActionResult ClaimUpdate(ClaimModelView cmv)
        {
            var query = ihaleClient.GetClaim(cmv.claimModel.Id);
            var claimGroup = ihaleClient.GetClaimGroups().FirstOrDefault(f => f.Name == cmv.claimModel.ClaimGroupName);
            query.Text = cmv.claimModel.Text;
            query.ClaimGroupId = claimGroup.Id;
            ihaleClient.UpdateClaim(query);
            return RedirectToAction("index");
        }
    }
}