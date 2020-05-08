using IM.PresentationLayer.IhaleWCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IM.PresentationLayer.Models
{
    public class AuctionModelView
    {
        /*
            hangi actiona kim ne kadar yatırmış olduğuna bakmak için
        */
        public List<actionuser> actionusers { get; set; }
        /*
         kullanıcıların hangi açıkartımalara kayıtlı olduğunu bulmak için
            yukardaki ikisinin farkı actionusers fiyat vereceğinden tablo sürekli tekrarlanıcak ve veri fazla olacak
            bu nedenle actionusers canlı acık artırma için private_auction ise kayıt contorlü için
        */
        public List<private_auction> private_Auctions { get; set; }
        /*
            spesifik olarak kullanıcı kendi bilgilerinide görebilecek
       */
        public User User { get; set; }
        /*
            user list işlemleri için çalışacak property
        */
        public List<User> Users { get; set; }
        /*
         faturaları listelemek için
             */
        public List<E_INVOICE> einvoices { get; set; }

        public List<UserProductModel> userProductModels { get; set; }
    }
}