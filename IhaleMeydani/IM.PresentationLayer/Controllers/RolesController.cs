 
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
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
        [ihaleClientFilter("Role.Görüntüle")] 
        public ActionResult Index()
        {
            var result = ihaleClient.GetRoles();
            return View(result);
        }
        [ihaleClientFilter("Role.Ekle")]
        public ActionResult AddRole(RolesModelView roles)
        {
            var groupList = (from r in ihaleClient.GetClaimGroups().AsQueryable()
                             select new ClaimGroupModelView()
                             {
                                 Id = r.Id,
                                 ClaimGroupName = r.Name
                             }).ToList();
            var query = (from r in ihaleClient.GetClaims().AsQueryable() 
                         select new RoleModel()
                         {
                             Checked = false, 
                             ClaimId = r.Id,
                             Text = r.Text,  
                             ClaimGroupId = r.ClaimGroupId
                         }).ToList();
            rm.roleList = query;
            rm.claimGroupList = groupList;
            return View(rm);
        }
        [Route("Roles/UpdateRole/{Id}")]
         [ihaleClientFilter("Role.Güncelle")] 
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
        [ihaleClientFilter("Role.Sil")]
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

            var oldName = ihaleClient.GetRoles().FirstOrDefault(x => x.Id == roles.Id);
            if (oldName != null)
            {  
                oldName.Name = roles.RoleName;
                ihaleClient.UpdateRole(oldName); 
            } 

            var oldRoles = ihaleClient.GetRoleClaims().Where(x => x.RoleId == roles.Id).ToList();
            if (oldRoles != null)
            {
                foreach (var item in oldRoles)
                {
                    ihaleClient.RemoveRoleClaim(item.Id); 
                }
            }
            for (int i = 0; i < roles.roleList.Count; i++)
            {
                var ur = roles.roleList[i];
                if (ur.Checked)
                {
                    var roleClaim = new RoleClaim() { ClaimId = ur.ClaimId, RoleId = oldName.Id };
                    ihaleClient.AddRoleClaim(roleClaim); 
                }
            }
            return RedirectToAction("index");
        }
    }
}