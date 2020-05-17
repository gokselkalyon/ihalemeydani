﻿using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IM.PresentationLayer.Controllers
{
    public class AuctionController : BaseController
    {
        AuctionModelView mv = new AuctionModelView();
        [HttpGet]
        [Route("auction/index")]
        public ActionResult Dashboard()
        {
            mv.auctions = IhaleServiceClient.GetUserAuctionModel().Where(x=>x.userid == SessionManager.CurrentUser.Id).ToList();
            return View(mv);
        }

        [HttpGet]
        [Route("auction/detail/{id}")]
        public ActionResult Details(int id)
        {
            mv.auction = IhaleServiceClient.GetUserAuctionModel().Where(x => x.userid == SessionManager.CurrentUser.Id && x.ID == id).FirstOrDefault();
            return View(mv);
        }

        [HttpGet]
        [Route("auction/create")]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [Route("auction/create")]
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
        [HttpGet]
        [Route("auction/Edit/{id}")]
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
