using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CISTAR.Hubs
{
    public class GameHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Ping()
        {
            ChatHub.Broadcast("GameHub", "Ping()");
        }

        public override Task OnConnected()
        {
            ChatHub.Broadcast("GameHub", "OnConnected()");
            return base.OnConnected();
        }
    }
}