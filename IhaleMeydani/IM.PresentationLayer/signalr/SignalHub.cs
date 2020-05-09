using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IM.PresentationLayer.IhaleWCFService;
using IM.PresentationLayer.Models;
using Microsoft.AspNet.SignalR;

namespace IM.PresentationLayer.signalr
{
    public class SignalHub : Hub
    {
        
        IhaleServiceClient ihaleService = new IhaleServiceClient();

        public override async Task OnConnected()
        {
            var actionusers = ihaleService.actionUserModelsAsync().Result;

            await Clients.Caller.OnConnected(actionusers.Where(x=>x.auction_id == AuctionModelView.auctionid ));
        }
        public void addauctionuser(actionuser actionuser)
        {
            actionuser.USER_ID = 1;// cookieden alınacak veya sessiondan
            actionuser.auction_id = AuctionModelView.auctionid;//bu veri siteden alınacak yani hangi sayfadaysa oradan alınacak
            ihaleService.Addactionuser(actionuser);// ekleme yapılacak tablo
            Clients.All.addauctionuser(ihaleService.actionUserModels().Where(x=>x.auction_id == AuctionModelView.auctionid)); //listelenecek tablo
        }
    }
}