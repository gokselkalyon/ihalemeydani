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

            bool db = Singleton.GetIhaleinstance().Getprivateauctions().Contains(new private_auction { auction_id = auctionid, USER_ID = SessionManager.CurrentUser.Id });
            if (!db)
                return false;
            return true;
        }

    }
}