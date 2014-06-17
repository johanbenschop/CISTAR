using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CISTAR.Hubs
{
    public class ChatHub : Hub
    {
        private static readonly Lazy<IHubContext> Lazy = new Lazy<IHubContext>(
            () => GlobalHost.ConnectionManager.GetHubContext<ChatHub>());

        private static IHubContext HubContext
        {
            get { return Lazy.Value; }
        }

        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }

        public static void Broadcast(string name, string message)
        {
            HubContext.Clients.All.broadcastMessage(name, message);
        }
    }
}