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
        [Route("auction/index")]
        public ActionResult Index()
        {
            
            return View(mv);
        }

        // kullanıcıların ürünlerinin bulunduğu sayfa
        [Route("auction/userproductdashboard")]
        public ActionResult UserProductsViewPage()
        {
            //SafeExecutor(() =>Console.WriteLine("goksel"));





            return View(mv);
        }
        //public void SafeExecutor(Action action)
        //{
        //    SafeExecutor(() => { action(); return 0; });
        //}


        //private T SafeExecutor<T>(Func<T> action)
        //{
        //    try
        //    {
        //        return action();
        //    }
        //    catch (Exception ex)
        //    {
        //        // common stuff
        //    }

        //    return default(T);
        //}



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
