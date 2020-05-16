﻿using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class BlogPostController : BaseController
    {
        
        BlogModelView bm = new BlogModelView();
        [Route("Blog")]
        public ActionResult Index()
        {
            bm.Posts = IhaleServiceClient.GetPosts().ToList();
            //IhaleServiceClient.AddPost();
            return View(bm);
        }
        [Route("BlogContent")]
        public ActionResult BlogIndex()
        {
            return View();
        }

        [Route("BlogAdmin")]
        public ActionResult AdminPanel()
        {
            return View();
        }
        [Route("BlogAdminCreate")]
        public ActionResult AdminPanelCreate()
        {
            return View();
        }
        [Route("BlogAdminUpdate")]
        public ActionResult AdminPanelUpdate()
        {
            return View();
        }
    }
}