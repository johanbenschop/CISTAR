using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public class EVEHeaders
    {
        public bool? Trusted { get; set; }
        public string ServerIp { get; set; }
        public string CharName { get; set; }
        public int CharId { get; set; }
        public string CorpName { get; set; }
        public int CorpId { get; set; }
        public string AllianceName { get; set; }
        public int AllianceId { get; set; }
        public string RegionName { get; set; }
        public string ConstellationName { get; set; }
        public string SolarSystemName { get; set; }
        public string StationName { get; set; }
        public int StationId { get; set; }
        public string CorpRole { get; set; }
        public int SolarSystemId { get; set; }
        public int WarFactionId { get; set; }
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public int ShipTypeId { get; set; }
        public string ShipTypeName { get; set; }
    }
}