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
        //public void Send(string username, string message)
        //{
        //    Clients.All.sendMessage(username, message);
        //}
        IhaleServiceClient ihaleService = new IhaleServiceClient();
        //log d = new log();

        public override async Task OnConnected()
        {
            var tags = ihaleService.GetTagsAsync().Result;
            await Clients.Caller.GetAllLog(tags);
        }
        public void addTag(tag tag)
        {
            ihaleService.AddTag(tag);
            Clients.All.addTag(tag);
        }
    }
}