using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{ 
    public class UserController : Controller
    {
        UserModelView user = new UserModelView();
        IhaleServiceClient ihaleClient = new IhaleServiceClient();
        // GET: User
        [HttpGet] 
        [Route("User")]
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
            user.userModel = query;
            return View(user);
        }
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
    }
}