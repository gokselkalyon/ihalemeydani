using IM.PresentationLayer.IhaleWCFService;
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
        public ActionResult Index()
        {
            var claimGroup = ihaleClient.GetClaims(); 
            return View(claimGroup);
        }
        public ActionResult AddClaim()
        {
            ClaimModelView cmv = new ClaimModelView();
            var query = ihaleClient.GetClaimGroups().Select(f => new ClaimModel { ClaimGroupName = f.Name }).ToList();
            cmv.claimGroupList = query;
            return View(cmv);
        }
        public ActionResult ClaimAdd(ClaimModelView cmv)
        {
            var claimGroup = ihaleClient.GetClaimGroups().FirstOrDefault(f => f.Name == cmv.claimModel.ClaimGroupName);
            Claim c = new Claim();
            c.Text = cmv.claimModel.Text;
            c.ClaimGroupId = claimGroup.Id;
            ihaleClient.AddClaim(c);
            return RedirectToAction("index");
        } 
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

}
}