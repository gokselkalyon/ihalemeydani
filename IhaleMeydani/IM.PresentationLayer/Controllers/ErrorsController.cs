using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{

    public class ErrorsController : Controller
    {
        [Route("Errors/Error401")]
        public ActionResult Error401()
        {
            return View();
        }
        [Route("Errors/Error403")]
        public ActionResult Error403()
        {
            return View();
        }
        [Route("Errors/Error404")]
        public ActionResult Error404()
        {
            return View();
        }
        [Route("Errors/Error405")]
        public ActionResult Error405()
        {
            return View();
        }
        [Route("Errors/Error406")]
        public ActionResult Error406()
        {
            return View();
        }
        [Route("Errors/Error412")]
        public ActionResult Error412()
        {
            return View();
        }
        [Route("Errors/Error500")]
        public ActionResult Error500()
        {
            return View();
        }
        [Route("Errors/Error501")]
        public ActionResult Error501()
        {
            return View();
        }
        [Route("Errors/Error502")]
        public ActionResult Error502()
        {
            return View();
        }

    }
}