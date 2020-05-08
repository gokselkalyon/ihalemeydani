using IM.BusinessLayer.Concrete;
using IM.DataAccessLayer.Tools;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class RolesController : BaseController
    {
        // GET: Roles 
        RolesModelView rm = new RolesModelView();
        public ActionResult Index()
        {
            var result = IhaleServiceClient.GetRoles();
            return View(result);
        }
        public ActionResult AddRole(RolesModelView roles)
        {
            var query = (from r in IhaleServiceClient.GetClaims()
                         select new RoleModel()
                         {
                             Checked = false,
                             ClaimId = r.Id,
                             Text = r.Text
                         }).ToList();
            rm.roleList = query;
            return View(rm);
        }
        [HttpPost]
        public JsonResult RoleCreate(RolesModelView roles)
        {
            var query = IhaleServiceClient.GetRoles().ToList();
            var roleNameControll = query.Where(f => f.Name == roles.RoleName).Any();
            if (roleNameControll)
            {
                jsonResultModel.Title = "Başarısız";
                jsonResultModel.Icon = "error";
                jsonResultModel.Description = "Role Ekleme Başarısız";
                //Burda hata Mesajı olucak!
            }
            Role r = new Role();
            r.Name = roles.RoleName;
            IhaleServiceClient.AddRole(r);
            RoleClaim rc = new RoleClaim();
            foreach (var items in roles.roleList)
            {
                if (items.Checked == true)
                {
                    rc.ClaimId = items.ClaimId;
                    rc.RoleId = r.Id;
                }
            }
            return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
    }
}