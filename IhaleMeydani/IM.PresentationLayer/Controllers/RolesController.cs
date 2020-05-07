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

        public ActionResult Index()
        {
            var result = db.GetRoles(); 
            return View(result);
        }
        public ActionResult AddRole(RolesModelView roles)
        {
            var query = (from r in db.GetClaims()
                         select new RolesModelView()
                         {
                             Checked = false,
                             Id = r.Id,
                             Name = r.Text
                         }).ToList();
            return View(query);
        }
    }
}