using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System.Linq;
using System.Web.Mvc; 

namespace IM.PresentationLayer.Controllers
{

    public class LoginController : BaseController
    {
        IhaleServiceClient ihaleClient = new IhaleServiceClient();

        // GET: Login
        [Route("Login")]
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
                        ur.Password = ln.Password;
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
    }
}