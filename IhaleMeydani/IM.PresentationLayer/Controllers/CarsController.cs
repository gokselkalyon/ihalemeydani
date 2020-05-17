﻿using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Razor;

namespace IM.PresentationLayer.Controllers
{
    public class CarsController : BaseController
    {

        AuctionModelView mv = new AuctionModelView();
        [HttpGet]
        [Route("auction/index/{auctionid}")]
        public ActionResult Index(int auctionid)
        {
            if (!Helper.Helper.userauctioncontrol(auctionid))//şuanda deneme amaçlı yapılıyor lakin bunu filter atributu ile kontrol edilecek
                return RedirectToRoute("default");

            mv.productModel = IhaleServiceClient.userProductModels().Where(x => x.id == SessionManager.CurrentUser.Id).FirstOrDefault();
            AuctionModelView.auctionid = auctionid;
            return View(mv);
        }

        // kullanıcıların ürünlerinin bulunduğu sayfa
        [ihaleClientFilter("Araba.Listele")]
        [Route("auction/userproductdashboard")]
        public ActionResult UserProductsViewPage()
        {
            int id = SessionManager.CurrentUser.Id;
            var userproductmodel = IhaleServiceClient.userProductModels().Where(x => x.user_id == SessionManager.CurrentUser.Id).ToList();
            mv.userProductModels = userproductmodel;
            mv.carpublished = userproductmodel.Where(x => x.published_on == true && x.isdeleted == false).Count();
            mv.carauctioncount = IhaleServiceClient.GetAuctions().Where(x => x.USER_ID == id).Count();
            return View(mv);
        }

        [ihaleClientFilter("Araba.Listele")]
        [Route("auction/Detail/{id}")]
        public ActionResult ProductDetail(int id)
        {
            mv.productModel = IhaleServiceClient.userProductModels().Where(x => x.id == id).FirstOrDefault();
            return View(mv);
        }


        // GET: Auction/Create
        [HttpGet]
        [Route("auction/Create")]
        [ihaleClientFilter("Araba.Ekle")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auction/Create
        [HttpPost]
        [ihaleClientFilter("Araba.Ekle")]
        [Route("auction/Create")]
        public ActionResult Create(UserProductModel carmodel)
        {
            try
            {
                carmodel.user_id = SessionManager.CurrentUser.Id;
                int deger = IhaleServiceClient.AdduserProductmodel(carmodel);
                return RedirectToAction("userproductdashboard");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Route("auction/Edit/{id}")]
        [ihaleClientFilter("Araba.Güncelle")]
        public ActionResult Edit(int id)
        {
            UserProductModel productModel = new UserProductModel();
            productModel = IhaleServiceClient.userProductModels().Where(x => x.id == id).FirstOrDefault();
            return View(productModel);
        }

        // POST: Auction/Edit/5
        [HttpPost]
        [Route("auction/Edit")]
        [ihaleClientFilter("Araba.Güncelle")]
        public ActionResult Edit(UserProductModel carmodel)
        {
            try
            {
                carmodel.user_id = SessionManager.CurrentUser.Id;
                int deger = IhaleServiceClient.UpdateuserProductmodel(carmodel);
                return RedirectToAction("userproductdashboard");
            }
            catch
            {
                return View("Edit/4");
            }
        }

        [Route("auction/Delete/{id}")]
        [ihaleClientFilter("Araba.Sil")]
        public ActionResult Delete(int id)
        {
            IhaleServiceClient.Updateuserproduct(new userproduct { id = id,isdeleted = true});
            return RedirectToAction("userproductdashboard");
        }
    }
}