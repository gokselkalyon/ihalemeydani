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
        List<actionuser> actionusers { get; set; }
        /*
         kullanıcıların hangi açıkartımalara kayıtlı olduğunu bulmak için
            yukardaki ikisinin farkı actionusers fiyat vereceğinden tablo sürekli tekrarlanıcak ve veri fazla olacak
            bu nedenle actionusers canlı acık artırma için private_auction ise kayıt contorlü için
        */
        List<private_auction> private_Auctions { get; set; }
        /*
            spesifik olarak kullanıcı kendi bilgilerinide görebilecek
       */    
        User User { get; set; }
        /*
            user list işlemleri için çalışacak property
        */
        List<User> Users { get; set; } 
        /*
         faturaları listelemek için
             */
        List<E_INVOICE> einvoices { get; set; }


    }
}