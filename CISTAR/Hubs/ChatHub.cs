using System;
using System.Threading.Tasks;
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

        public override Task OnConnected()
        {
            Clients.Caller.broadcastMessage("System", string.Format("You are using the {0} transport.", Context.QueryString.Get("transport")));
            Clients.Caller.broadcastMessage("System", "Happy debugging!");
            return base.OnConnected();
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