using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.LoginSecurity;
using IM.PresentationLayer.Models;
using Microsoft.AspNet.SignalR;

namespace IM.PresentationLayer.signalr
{
    public class SignalHub : Hub
    {
        
        IhaleServiceClient ihaleService = new IhaleServiceClient();

        public override async Task OnConnected()
        {
            var tablo = ihaleService.actionUserModelsAsync().Result;
            var ordertablo = tablo.Where(x => x.auction_id == AuctionModelView.auctionid).OrderByDescending(x => x.bid).Take(5).ToList();
            var actionusers = ordertablo;

            await Clients.Caller.OnConnected(actionusers);
        }
        public void addauctionuser(actionuser actionuser)
        {
            actionuser.USER_ID = 18;// cookieden alınacak veya sessiondan
            actionuser.auction_id = AuctionModelView.auctionid;//bu veri siteden alınacak yani hangi sayfadaysa oradan alınacak
            ihaleService.Addactionuser(actionuser);// ekleme yapılacak tablo
            List<ActionUserModel> ordertablo = getactionuser(5);
            Clients.All.addauctionuser(ordertablo); //listelenecek tablo
        }

        public void addautoauctionuser()
        {
            actionuser actionuser = new actionuser();
            actionuser.USER_ID = 18;// cookieden alınacak veya sessiondan
            actionuser.auction_id = AuctionModelView.auctionid;//bu veri siteden alınacak yani hangi sayfadaysa oradan alınacak
            decimal autoprice = 0;
            decimal maxprice = getactionuser(1).FirstOrDefault().bid;
            decimal increase_amount = ihaleService.GetUserAuctionModel().Where(x => x.ID == AuctionModelView.auctionid).FirstOrDefault().INCREASE_PRICE;
            decimal zero = 0;
            while (zero < maxprice)
            {
                zero += increase_amount;
            }
            zero += increase_amount;
            autoprice = zero;
            actionuser.bid = autoprice;
            ihaleService.Addactionuser(actionuser);// ekleme yapılacak tablo
            List<ActionUserModel> ordertablo = getactionuser(5);
            Clients.All.addauctionuser(ordertablo); //listelenecek tablo
        }
        private List<ActionUserModel> getactionuser(int takecount)
        {
            List<ActionUserModel> tablo = ihaleService.actionUserModels().Where(x => x.auction_id == AuctionModelView.auctionid).ToList();
            var ordertablo = tablo.OrderByDescending(x => x.bid).Take(takecount).ToList();
            return ordertablo;
        }
    }
}