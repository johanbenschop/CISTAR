using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CISTAR.Models
{
    public class Pilot
    {
        public Pilot()
        {

        }

        public int CharacterId { get; internal set; }
        public string CharacterName { get; internal set; }

        public Corporation Corporation { get; internal set; }

        public string CorporationRole { get; internal set; } // TODO check type!

        public string RegionName { get; internal set; }
        public string ConstellationName { get; internal set; }
        public string SolarSystemName { get; internal set; }
        public int SolarSystemId { get; internal set; }
        public string StationName { get; internal set; }
        public int StationId { get; internal set; }

        public int WarFactionId { get; internal set; } // TODO What is this?


        public Ship Ship { get; set; }



    }
}