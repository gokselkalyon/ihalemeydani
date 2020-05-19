using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Helper
{
    public class Helper
    {

        /// <summary>
        /// kullanıcının verilen auction'a kayıtlı olup olmadığına bakıyoruz
        /// </summary>
        /// <param name="auctionid"></param>
        /// <returns name="bool"></returns>
        public static bool userauctioncontrol(int auctionid)
        {

            var db = Singleton.GetIhaleinstance().Getprivateauctions().Where(x=>x.auction_id == auctionid && x.USER_ID == SessionManager.CurrentUser.Id ).Count();
            if (db <= 0)
                return false;
            return true;
        }

    }
}