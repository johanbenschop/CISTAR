using System;
using System.Linq;
using System.Collections.Generic;
using CISTAR.Hubs;
using CISTAR.Models;

namespace CISTAR.Middleware
{
    /// <summary>
    /// Description of PilotsController
    /// </summary>
    public sealed class PilotsController
    {
        private static readonly PilotsController instance = new PilotsController();
        //private readonly EveStaticDataModel _staticDataModel = new EveStaticDataModel();
        private readonly ICollection<Pilot> _pilots;

        public static PilotsController Instance
        {
            get
            {
                return instance;
            }
        }

        private PilotsController()
        {
            _pilots = new List<Pilot>();
        }

        public void UpdatePilot(EVEHeaders headers)
        {
            if (!headers.Trusted) return;
            //var pilot = GetPilotById(headers.CharId) ?? new Pilot();
            var pilot = GetPilotById(headers.CharId);

            if (pilot == null)
            {
                pilot = new Pilot();
                pilot.PropertyChanged += pilot_PropertyChanged;
            }

            pilot.CharacterId = headers.CharId;
            pilot.CharacterName = headers.CharName;
            pilot.WarFactionId = headers.WarFactionId;
            pilot.SolarSystem = new SolarSystem() { Id = headers.SolarSystemId, Name = headers.SolarSystemName };
            pilot.Station = new Station() { Id = headers.StationId, Name = headers.StationName };
            pilot.Region = new Region() { Id = headers.RegionId, Name = headers.RegionName };
            pilot.Constellation = new Constellation() { Id = headers.ConstellationId, Name = headers.ConstellationName };
            pilot.Corporation = new Corporation() { Id = headers.CorpId, Name = headers.CorpName };
            pilot.CorporationRole = headers.CorpRole;
            pilot.Ship = new Ship() { Id = headers.ShipId, Name = headers.ShipName, TypeId = headers.ShipTypeId, TypeName = headers.ShipTypeName };

            _pilots.Add(pilot);
        }

        void pilot_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var val = sender.GetType().GetProperty(e.PropertyName).GetValue(sender, null);
            ChatHub.Broadcast(e.PropertyName, val.ToString());
        }

        public Pilot GetPilotByName(string name)
        {
            return _pilots.FirstOrDefault(a => a.CharacterName == name); ;
        }

        public Pilot GetPilotById(int id)
        {
            return _pilots.FirstOrDefault(a => a.CharacterId == id); ;
        }
    }
}
