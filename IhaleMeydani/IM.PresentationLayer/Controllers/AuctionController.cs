﻿using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class AuctionController : Controller
    {
        AuctionModelView mv = new AuctionModelView();
        // GET: Auction
        [Route("auction/index")]
        public ActionResult Index()
        {
            
            return View(mv);
        }

        // GET: Auction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Auction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auction/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Auction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Auction/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Auction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Auction/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
