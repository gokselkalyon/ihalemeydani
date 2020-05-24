using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class IconsController : BaseController
    {
        // GET: Icons
        [Route("Icons")]
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult List()
        {
            return PartialView(IhaleServiceClient.GetIcons().ToList());
        }
    }
}