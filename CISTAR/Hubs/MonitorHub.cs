using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CISTAR.Hubs
{
    public class MonitorHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}