using IM.BusinessLayer.Concrete;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class RolesController : Controller
    {
        // GET: Roles 
        IhaleServiceClient db = new IhaleServiceClient();
        RolesModelView rm = new RolesModelView();
        public ActionResult Index()
        {
            var result = db.GetRoles();
            return View(result);
        }
        public ActionResult AddRole(RolesModelView roles)
        {
            var query = (from r in db.GetClaims()
                         select new RoleModel()
                         {
                             Checked = false,
                             ClaimId = r.Id,
                             Text = r.Text
                         }).ToList();
            rm.roleList = query;
            return View(rm);
        }
        public ActionResult RoleCreate(RolesModelView roles)
        {
            var query = db.GetRoles().ToList();
            var roleNameControll = query.Where(f => f.Name == roles.RoleName).Any();
            if (roleNameControll)
            {
                return View();
                //Burda hata Mesajı olucak!
            }
            Role r = new Role();
            r.Name = roles.RoleName;
            db.AddRole(r);
            RoleClaim rc = new RoleClaim();
            foreach (var items in roles.roleList)
            {
                if (items.Checked == true)
                {
                    rc.ClaimId = items.ClaimId;
                    rc.RoleId = r.Id;
                }
            }
            return View();
        }
    }
}