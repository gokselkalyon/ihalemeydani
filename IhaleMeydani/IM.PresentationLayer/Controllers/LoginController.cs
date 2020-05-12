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
                        ur.Password = EncrypModel.EncryptSHA1(ln.Password);
                        var result = ur.Password.Length;
                        ur.UserName = ln.Username;
                        ihaleClient.AddUser(ur);
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
            ln.Password = EncrypModel.EncryptSHA1(ln.Password);
            var user = ihaleClient.GetUsers().Where(f => f.UserName == ln.Username && f.Password == ln.Password).FirstOrDefault();
            if (user.IsDeleted != true)
            {
                if (user != null)
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
    }
}