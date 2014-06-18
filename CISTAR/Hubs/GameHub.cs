using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CISTAR.Hubs
{
    public class GameHub : Hub<IGameHub>
    {
        public void Ping()
        {
            ChatHub.Broadcast("GameHub", "Ping()");
        }

        public override Task OnConnected()
        {
            ChatHub.Broadcast("GameHub", string.Format("OnConnected() // "));
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            ChatHub.Broadcast("GameHub", string.Format("OnDisconnected(stopCalled {0})", stopCalled));
            return base.OnDisconnected(stopCalled);
        }
    }
}