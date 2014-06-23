using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CISTAR.Middleware;
using CISTAR.Models;
using Microsoft.AspNet.SignalR;
using Microsoft.SqlServer.Server;
using WebGrease;

namespace CISTAR.Hubs
{
    public class GameHub : Hub<IGameHub>
    {
        public void Ping()
        {
            //ChatHub.Broadcast("GameHub", "Ping()");

            EVEHeaders headers;
            headers = new EVEHeaders();
            headers.CharId = GetIntFromHeader("EVE_CHARID");
            headers.CharName = Context.Headers.Get("EVE_CHARNAME");
            headers.AllianceId = GetIntFromHeader("EVE_ALLIANCEID");
            headers.AllianceName = Context.Headers.Get("EVE_ALLIANCENAME");
            headers.ConstellationId = GetIntFromHeader("EVE_CONSTELLATIONID");
            headers.ConstellationName = Context.Headers.Get("EVE_CONSTELLATIONNAME");
            headers.CorpId = GetIntFromHeader("EVE_CORPID");
            headers.CorpName = Context.Headers.Get("EVE_CORPNAME");
            headers.CorpRole = Context.Headers.Get("EVE_CORPROLE");
            headers.RegionId = GetIntFromHeader("EVE_REGIONID");
            headers.RegionName = Context.Headers.Get("EVE_REGIONNAME");
            headers.ServerIp = Context.Headers.Get("EVE_SERVERIP");
            headers.ShipId = GetLongFromHeader("EVE_SHIPID");
            headers.ShipName = Context.Headers.Get("EVE_SHIPNAME");
            headers.ShipTypeId = GetIntFromHeader("EVE_SHIPTYPEID");
            headers.ShipTypeName = Context.Headers.Get("EVE_SHIPTYPENAME");
            headers.SolarSystemId = GetIntFromHeader("EVE_SOLARSYSTEMID");
            headers.SolarSystemName = Context.Headers.Get("EVE_SOLARSYSTEMNAME");
            headers.StationId = GetIntFromHeader("EVE_STATIONID");
            headers.StationName = Context.Headers.Get("EVE_STATIONNAME");
            headers.Trusted = Context.Headers.Get("EVE_TRUSTED").Equals("Yes");
            headers.WarFactionId = GetIntFromHeader("EVE_WARFACTIONID");

            PilotsController.Instance.UpdatePilot(headers);
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

        private int GetIntFromHeader(string header)
        {
            var value = Context.Headers.Get(header);
            return value != null ? int.Parse(value) : -1;
        }

        private long GetLongFromHeader(string header)
        {
            var value = Context.Headers.Get(header);
            return value != null ? long.Parse(value) : -1;
        }
    }
}