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
    public class UserController : BaseController
    {
        UserModelView user = new UserModelView();
        IhaleServiceClient ihaleClient = new IhaleServiceClient();
        // GET: User
        [HttpGet]
        [Route("User/Profile/{id}")]
        [ihaleClientFilter("Kullanıcı.Profil")]
        public ActionResult UserProfile(int id)
        {
            var query = (from r in ihaleClient.GetUsers()
                         where r.Id == id
                         select new UserModel
                         {
                             Id = r.Id,
                             Name = r.Name,
                             Surname = r.Surname,
                             Email = r.Email,
                             Adress = r.Adress,
                             CompanyName = r.CompanyName,
                             DateOfBirt = r.Dateofbird,
                             IdentityNo = r.IdentityNo,
                             IsDeleted = r.IsDeleted,
                             Username = r.UserName,
                             Phone = r.Phone
                         }).FirstOrDefault();
            user.userModel = query;
            return View(user);
        }



        [HttpGet] 
        [Route("User/View")]
        [ihaleClientFilter("Kullanıcı.Listele")]
        public ActionResult Index()
        {
            var query = (from r in ihaleClient.GetUsers()
                         select new UserModel
                         {
                             Id = r.Id,
                             Name = r.Name,
                             Surname = r.Surname,
                             Email = r.Email,
                             Adress = r.Adress, 
                             CompanyName = r.CompanyName,
                             DateOfBirt = r.Dateofbird,
                             IdentityNo = r.IdentityNo,
                             IsDeleted = r.IsDeleted,
                             Username = r.UserName,
                             Phone = r.Phone
                         }).ToList();
            user.userModelList = query; 
            return View(user);
        }
        [ihaleClientFilter("Kullanıcı.Engelle")]
        public JsonResult UserBlock(int id) 
        {
            try
            {
                var user = ihaleClient.GetUser(id);
                if (user.IsDeleted == true)
                    user.IsDeleted = false;
                else
                    user.IsDeleted = true;
                ihaleClient.UpdateUser(user);
                return Json(1, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            { 
                return Json(0, JsonRequestBehavior.AllowGet);
            } 
        }
        [Route("User/Update/{id}")]
        [ihaleClientFilter("Kullanıcı.Güncelle")]
        public ActionResult UserRoleUpdate(int id)
        {
            var query = (from r in ihaleClient.GetUsers() 
                         where r.Id == id
                         select new UserModel
                         {
                             Id = r.Id,
                             Name = r.Name,
                             Surname = r.Surname,
                             Email = r.Email,
                             Adress = r.Adress,
                             CompanyName = r.CompanyName,
                             DateOfBirt = r.Dateofbird,
                             IdentityNo = r.IdentityNo,
                             IsDeleted = r.IsDeleted,
                             Username = r.UserName,
                             Phone = r.Phone
                         }).FirstOrDefault();
            var roles = (from r in ihaleClient.GetRoles()
                         select new RoleModel()
                         {
                             Checked = false,
                             RoleId = r.Id,
                             Text = r.Name
                         }).ToList(); 
            var userRole = ihaleClient.GetUserRoles().Where(x => x.User_Id == id).ToList(); 
            for (int i = 0; i < userRole.Count; i++)
            {
                var r = userRole[i].Role_Id;
                var ur = roles.FirstOrDefault(x => x.RoleId == r);
                if (ur != null)
                    ur.Checked = true;
            }
            user.userModel = query;
            user.roleModelList = roles;
            return View(user); 
        }
        [HttpPost] 
        public ActionResult RoleUpdate(UserModelView user)
        {
            try
            {
                var oldRoles = ihaleClient.GetUserRoles().Where(x => x.User_Id == user.userModel.Id);
                if (oldRoles != null)
                {
                    foreach (var item in oldRoles)
                    {
                        ihaleClient.RemoveUserRole(item.Id);
                    }
                }
                for (int i = 0; i < user.roleModelList.Count; i++)
                {
                    var ur = user.roleModelList[i];
                    if (ur.Checked)
                    {
                        var userRole = new UserRole() { User_Id = user.userModel.Id, Role_Id = ur.RoleId };
                        ihaleClient.AddUserRole(userRole);
                    }
                }
                TempData["RoleMessage"] = "Yetki Güncelleme Başarılı!";
            }
            catch (Exception)
            {
                TempData["RoleMessage"] = "Yetki Güncelleme Başarısız!";
                throw;
            }
            return RedirectToAction("View", "User");
        }
            
    }
}