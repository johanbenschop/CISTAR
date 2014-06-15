using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public enum IGBHeaders
    {
        Trusted,
        ServerIp,
        CharName,
        CharId,
        CorpName,
        CorpId,
        AllianceName,
        AllianceId,
        RegionName,
        ConstellationName,
        SolarSystemName,
        StationName,
        StationId,
        CorpRole,
        SolarSystemId,
        WarFactionId,
        ShipId,
        ShipName,
        ShipTypeId,
        ShipTypeName,
    }
}

/*
HTTP_EVE_TRUSTED
HTTP_EVE_SERVERIP
HTTP_EVE_CHARNAME
HTTP_EVE_CHARID
HTTP_EVE_CORPNAME
HTTP_EVE_CORPID
HTTP_EVE_ALLIANCENAME
HTTP_EVE_ALLIANCEID
HTTP_EVE_REGIONNAME
HTTP_EVE_CONSTELLATIONNAME
HTTP_EVE_SOLARSYSTEMNAME
HTTP_EVE_STATIONNAME
HTTP_EVE_STATIONID
HTTP_EVE_CORPROLE
HTTP_EVE_SOLARSYSTEMID
HTTP_EVE_WARFACTIONID
HTTP_EVE_SHIPID
HTTP_EVE_SHIPNAME
HTTP_EVE_SHIPTYPEID
HTTP_EVE_SHIPTYPENAME
*/