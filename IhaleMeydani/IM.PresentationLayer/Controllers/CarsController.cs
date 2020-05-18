using IM.PresentationLayer.IhaleWCFService;
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

        // açık artırmanın teklif verildiği sayfa
        [HttpGet]
        //[ihaleClientFilter("privateauction.listele")]
        [Route("Cars/index/{auctionid}")]
        public ActionResult Index(int auctionid)
        {
            if (!Helper.Helper.userauctioncontrol(auctionid))//şuanda deneme amaçlı yapılıyor lakin bunu filter atributu ile kontrol edilecek
                return RedirectToRoute("default");

            int dd = SessionManager.CurrentUser.Id;
            mv.auction = IhaleServiceClient.GetUserAuctionModel().Where(x => x.ID == auctionid).FirstOrDefault();
            AuctionModelView.auctionid = auctionid;
            return View(mv);
        }

        //araçların listelendiği sayfa
        [HttpGet]
        [Route("Cars/list")]
        public ActionResult Carslist()
        {
            try
            {
                mv.userProductModels = IhaleServiceClient.userProductModels().Where(x => x.isdeleted == false).ToList();

            }
            catch (Exception ex)
            {
                var deneme = ex.Message;
            }
            return View(mv);
        }

        // kullanıcıların ürünlerinin bulunduğu sayfa
        [HttpGet]
        [ihaleClientFilter("Araba.Listele")]
        [Route("Cars/userproductdashboard")]
        public ActionResult UserProductsViewPage()
        {
            int id = SessionManager.CurrentUser.Id;
            var userproductmodel = IhaleServiceClient.userProductModels().Where(x => x.user_id == SessionManager.CurrentUser.Id).ToList();
            mv.userProductModels = userproductmodel;
            mv.carpublished = userproductmodel.Where(x => x.published_on == true && x.isdeleted == false).Count();
            mv.carauctioncount = IhaleServiceClient.GetAuctions().Where(x => x.USER_ID == id).Count();
            return View(mv);
        }

        [HttpGet]
        [ihaleClientFilter("Araba.Listele")]
        [Route("Cars/Detail/{id}")]
        public ActionResult ProductDetail(int id)
        {
            mv.productModel = IhaleServiceClient.userProductModels().Where(x => x.id == id).FirstOrDefault();
            return View(mv);
        }


        // GET: Auction/Create
        [HttpGet]
        [Route("Cars/Create")]
        [ihaleClientFilter("Araba.Ekle")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auction/Create
        [HttpPost]
        [ihaleClientFilter("Araba.Ekle")]
        [Route("Cars/Create")]
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
        [Route("Cars/Edit/{id}")]
        [ihaleClientFilter("Araba.Güncelle")]
        public ActionResult Edit(int id)
        {
            UserProductModel productModel = new UserProductModel();
            productModel = IhaleServiceClient.userProductModels().Where(x => x.id == id).FirstOrDefault();
            return View(productModel);
        }

        // POST: Auction/Edit/5
        [HttpPost]
        [Route("Cars/Edit")]
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

        [HttpGet]
        [Route("Cars/Delete/{id}")]
        [ihaleClientFilter("Araba.Sil")]
        public ActionResult Delete(int id)
        {
            IhaleServiceClient.Updateuserproduct(new userproduct { id = id,isdeleted = true});
            return RedirectToAction("userproductdashboard");
        }
    }
}
