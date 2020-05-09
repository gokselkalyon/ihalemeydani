using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
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
        [Route("auction/index/{auctionid}")]
        public ActionResult Index(int auctionid)
        {
            if (!Helper.Helper.userauctioncontrol(auctionid))//şuanda deneme amaçlı yapılıyor lakin bunu filter atributu ile kontrol edilecek
                return RedirectToRoute("default");

            mv.productModel = new IhaleServiceClient().userProductModels().Where(x => x.id == 1).FirstOrDefault();
            AuctionModelView.auctionid = auctionid;
            return View(mv);
        }

        // kullanıcıların ürünlerinin bulunduğu sayfa
        [Route("auction/userproductdashboard")]
        public ActionResult UserProductsViewPage()
        {
           
            IhaleServiceClient db = new IhaleServiceClient();
            mv.userProductModels = db.userProductModels().Where(x=>x.user_id == 1).ToList();
            mv.carpublished = db.userProductModels().Where(x => x.user_id == 1 && x.published_on == true).Count();

            return View(mv);
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
