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
        UserAuctionModel uam = new UserAuctionModel();

        [HttpGet]
        [ihaleClientFilter("auction.listele")]
        [Route("auction/index")]
        public ActionResult Dashboard()
        {
            mv.auctions = IhaleServiceClient.GetUserAuctionModel().Where(x=>x.userid == SessionManager.CurrentUser.Id).ToList();
            return View(mv);
        }

        [HttpGet]
        [ihaleClientFilter("auction.listele")]
        [Route("auction/detail/{id}")]
        public ActionResult Details(int id)
        {
            mv.auction = IhaleServiceClient.GetUserAuctionModel().Where(x => x.userid == SessionManager.CurrentUser.Id && x.ID == id).FirstOrDefault();
            return View(mv);
        }

        [HttpGet]
        [ihaleClientFilter("auction.ekle")]
        [Route("auction/create")]
        public ActionResult Create()
        {
            int id = SessionManager.CurrentUser.Id;
            mv.userProductModels = IhaleServiceClient.userProductModels().Where(x => x.user_id == SessionManager.CurrentUser.Id && x.published_on == true && x.isdeleted == false && x.isSaled == false).ToList();
            mv.currencies = IhaleServiceClient.GetCurrencies().ToList();
            return View(mv);
        }

        
        [HttpPost]
        [ihaleClientFilter("auction.ekle")]
        [Route("auction/create")]
        public ActionResult Create(AuctionModelView uam)
        {
            try
            {
                uam.auction.userid = SessionManager.CurrentUser.Id;
                int deger = IhaleServiceClient.AddUserAuctionModel(uam.auction);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        [ihaleClientFilter("auction.guncelle")]
        [Route("auction/Edit/{id}")]
        public ActionResult Edit(int id)
        {
            mv.auction = IhaleServiceClient.GetUserAuctionModel().Where(x => x.userid == SessionManager.CurrentUser.Id && x.ID == id).FirstOrDefault();
            
            mv.userProductModels = IhaleServiceClient.userProductModels().Where(x => x.user_id == SessionManager.CurrentUser.Id && x.published_on == true && x.isdeleted == false && x.isSaled == false).ToList();
            mv.currencies = IhaleServiceClient.GetCurrencies().ToList();
            return View(mv);
        }

        // POST: Auction/Edit/5
        [HttpPost]
        [ihaleClientFilter("auction.guncelle")]
        [Route("auction/Edit")]
        public ActionResult Edit(AuctionModelView uam)
        {
            try
            {
                uam.auction.userid = SessionManager.CurrentUser.Id;
                int deger = IhaleServiceClient.UpadateUserAuctionModel(uam.auction);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        [Route("auction/delete")]
        [ihaleClientFilter("auction.sil")]
        public ActionResult Delete(int id)
        {
            IhaleServiceClient.Updateuserproduct(new userproduct { id = id, isdeleted = true });
            return RedirectToAction("Index");
        }

    }
}
