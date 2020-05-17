using IM.BusinessLayer.Firebase;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Helper
{
    public class Singleton
    {
		private static IhaleServiceClient Ihale;
        private static JsonResultModel jsonResultModel;
        private static FirebaseStorageHelper firebaseStorageHelper;

        public static IhaleServiceClient GetIhaleinstance()
        {
            if (Ihale == null)
                Ihale = new IhaleServiceClient();
            return Ihale;
        }
        public static JsonResultModel GetjsonResultModelinstance()
        {
            if (jsonResultModel == null)
                jsonResultModel = new JsonResultModel();
            return jsonResultModel;
        }
        public static FirebaseStorageHelper GetfirebaseStorageHelperinstance()
        {
            if (firebaseStorageHelper == null)
                firebaseStorageHelper = new FirebaseStorageHelper("ihale-meydan.appspot.com");
            return firebaseStorageHelper;
        }
    }
}