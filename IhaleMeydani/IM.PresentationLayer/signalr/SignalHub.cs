using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using IM.PresentationLayer.IhaleWCFService;
using Microsoft.AspNet.SignalR;

namespace IM.PresentationLayer.signalr
{
    public class SignalHub : Hub
    {
        
        IhaleServiceClient ihaleService = new IhaleServiceClient();

        public override async Task OnConnected()
        {
            var actionusers = ihaleService.GetactionusersAsync().Result;
            await Clients.Caller.GetAllLog(actionusers);
        }
        public void addauctionuser(actionuser actionuser)
        {
            actionuser.USER_ID = 1;// cookieden alınacak

            actionuser.auction_id = 1;//cookiden alınacak
            ihaleService.Addactionuser(actionuser);
            Clients.All.addauctionuser(actionuser);
        }
    }
}