using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace IM.PresentationLayer.signalr
{
    public class SignalHub : Hub
    {
        //public void Send(string username, string message)
        //{
        //    Clients.All.sendMessage(username, message);
        //}

        public override Task OnConnected()
        {
            return base.OnConnected();  
        }
    }
}