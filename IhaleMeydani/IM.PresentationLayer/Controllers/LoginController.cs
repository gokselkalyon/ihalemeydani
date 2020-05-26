using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;

namespace IM.PresentationLayer.Controllers
{

    public class LoginController : BaseController
    {
        IhaleServiceClient ihaleClient = new IhaleServiceClient();

        // GET: Login
        [Route("Login")]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult UserCreate(LoginModelView ln)
        {
            var userCheckEmail = ihaleClient.GetUsers().Where(f=>f.Email == ln.Email).Any();
            var userUserNameCheck = ihaleClient.GetUsers().Where(f => f.UserName == ln.Username).Any();
            if (!userCheckEmail)
            {
                if (!userUserNameCheck)
                {
                    User ur = new User();
                    if (ln.Password == ln.Password2)
                    {
                        ur.Email = ln.Email;
                        ur.Password = EncrypModelView.EncryptSHA1(ln.Password);
                        var result = ur.Password.Length;
                        ur.UserName = ln.Username;
                        ihaleClient.AddUser(ur);
                        var roleName = ihaleClient.GetRoles().FirstOrDefault(f => f.Name == ln.RoleType);
                        var newCustomer = ihaleClient.GetUsers().FirstOrDefault(f => f.UserName == ln.Username).Id;
                        UserRole userRole = new UserRole();
                        userRole.Role_Id = roleName.Id;
                        userRole.User_Id = newCustomer;
                        ihaleClient.AddUserRole(userRole);
                        return Json(1, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        return Json(2, JsonRequestBehavior.AllowGet);
                    }
                } 
                else
                {
                    return Json(3, JsonRequestBehavior.AllowGet);
                }
            }
            else
            {
                return Json(4, JsonRequestBehavior.AllowGet);
            }  
        }
        [AllowAnonymous]
        public JsonResult UserLogin(LoginModelView ln)
        { 
            ln.Password = EncrypModelView.EncryptSHA1(ln.Password);
            var user = ihaleClient.GetUsers().Where(f => f.UserName == ln.Username && f.Password == ln.Password).FirstOrDefault();
            if (user != null)
            {
                if (user.IsDeleted != true)
                {
                    var p = (from x in ihaleClient.GetUsers()
                             where x.UserName == ln.Username
                             select new UserModel()
                             {
                                 Name = x.Name,
                                 Username = x.UserName,
                                 Id = x.Id
                             }).FirstOrDefault();
                    SessionManager.Current.Set(SessionKey.CurrentUser, p);
                    FormsAuthentication.SetAuthCookie(user.Id.ToString(), false);
                    var query = ihaleClient.GetUserRoles().Where(f => f.User_Id == p.Id).ToList();
                    foreach (var item in query)
                    {
                        var FindRoleName = ihaleClient.GetRoles().Where(f => f.Id == item.Role_Id).FirstOrDefault();
                        if (FindRoleName.Name == "Admin")
                        {
                            return Json(4, JsonRequestBehavior.AllowGet);
                        }
                    }
                    return Json(1, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(3, JsonRequestBehavior.AllowGet);
                }
              
            }
            else
            {
                return Json(2, JsonRequestBehavior.AllowGet);
            }
         
        }
    }
}