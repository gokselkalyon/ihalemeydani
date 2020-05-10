using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class RolesController : BaseController
    {
        // GET: Roles 
        RolesModelView rm = new RolesModelView();
        IhaleServiceClient ihaleClient = new IhaleServiceClient();
        public ActionResult Index()
        {
            var result = ihaleClient.GetRoles();
            return View(result);
        }
        public ActionResult AddRole(RolesModelView roles)
        {
            var query = (from r in ihaleClient.GetClaims()
                         select new RoleModel()
                         {
                             Checked = false,
                             ClaimId = r.Id,
                             Text = r.Text
                         }).ToList();
            rm.roleList = query;
            return View(rm);
        }
        [Route("Roles/UpdateRole/{Id}")]
        public ActionResult UpdateRole(int Id)
        {
            var roleName = ihaleClient.GetRole(Id).Name;
            var query = (from r in ihaleClient.GetClaims()
                         select new RoleModel()
                         {
                             Checked = false,
                             ClaimId = r.Id,
                             Text = r.Text
                         }).ToList();
            rm.roleList = query;
            rm.Id = Id;
            rm.RoleName = roleName;
            var roleClaim = ihaleClient.GetRoleClaims().Where(f => f.RoleId == Id).ToList();
            for (int i = 0; i < roleClaim.Count; i++)
            {
                var r = roleClaim[i].ClaimId;
                var ur = query.FirstOrDefault(x => x.ClaimId == r);
                if (ur != null)
                    ur.Checked = true;
            }
            return View(rm);
        }
        [HttpPost]
        public ActionResult RoleCreate(RolesModelView roles)
        {
            var query = ihaleClient.GetRoles().ToList();
            var roleNameControll = query.Where(f => f.Name == roles.RoleName).Any();
            if (roleNameControll)
            {
                jsonResultModel.Title = "Başarısız";
                jsonResultModel.Icon = "error";
                jsonResultModel.Description = "Role Ekleme Başarısız";
            }
            Role r = new Role();
            r.Name = roles.RoleName;
            ihaleClient.AddRole(r);
            RoleClaim rc = new RoleClaim();
            var roleId = ihaleClient.GetRoles().FirstOrDefault(f => f.Name == r.Name).Id;
            if (roles.roleList != null)
            {
                foreach (var items in roles.roleList)
                {
                    if (items.Checked == true)
                    {
                        rc.ClaimId = items.ClaimId;
                        rc.RoleId = roleId;
                        ihaleClient.AddRoleClaim(rc);
                    }
                }
            }
            else
            {
                jsonResultModel.Title = "Başarısız";
                jsonResultModel.Icon = "error";
                jsonResultModel.Description = "Role Ekleme Başarısız";
            }
            return RedirectToAction("index");
            //return Json(jsonResultModel, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult RoleDelete(int id)
        {
            try
            {
                ihaleClient.RemoveRole(id);
                var result = ihaleClient.GetRoleClaims().Where(f => f.RoleId == id);
                foreach (var item in result)
                {
                    ihaleClient.RemoveRoleClaim(item.Id);
                }
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
        public ActionResult RoleUpdate(RolesModelView roles)
        {
            var oldName = ihaleClient.GetRoles().FirstOrDefault(x => x.Name == roles.RoleName);
            if (oldName != null)
            {
                Role r = new Role();
                oldName.Name = roles.RoleName;
                ihaleClient.UpdateRole(r);
            }
            return RedirectToAction("index");
        }
    }
}