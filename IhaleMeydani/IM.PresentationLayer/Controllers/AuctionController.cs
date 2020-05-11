using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
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
        [Route("auction/userproductdashboard")]
        public ActionResult UserProductsViewPage()
        {
            int de = SessionManager.CurrentUser.Id;
            mv.userProductModels = IhaleServiceClient.userProductModels().Where(x=>x.user_id == SessionManager.CurrentUser.Id).ToList();
            mv.carpublished = IhaleServiceClient.userProductModels().Where(x => x.user_id == SessionManager.CurrentUser.Id && x.published_on == true).Count();
            mv.User = IhaleServiceClient.GetUser(SessionManager.CurrentUser.Id);
            return View(mv);
        }


        // GET: Auction/Create
        [Route("auction/productcreate")]
        public ActionResult ProductCreate()
        {
            return View();
        }

        // POST: Auction/Create
        [HttpPost]
        [Route("auction/productcreate/{carmodel}")]
        public ActionResult Create(UserProductModel carmodel)
        {
            try
            {
                carmodel.
                IhaleServiceClient.add

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
