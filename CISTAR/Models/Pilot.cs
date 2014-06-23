using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CISTAR.Annotations;

namespace CISTAR.Models
{
    public class Pilot : INotifyPropertyChanged
    {
        private Corporation _corporation;
        private string _corporationRole;
        private Region _region;
        private Constellation _constellation;
        private SolarSystem _solarSystem;
        private Station _station;
        private int _warFactionId;
        private Ship _ship;

        public Pilot()
        {

        }

        public int CharacterId { get; internal set; }
        public string CharacterName { get; internal set; }

        public Corporation Corporation
        {
            get { return _corporation; }
            internal set
            {
                if (Equals(value, _corporation)) return;
                _corporation = value;
                OnPropertyChanged();
            }
        }

        public string CorporationRole
        {
            get { return _corporationRole; }
            internal set
            {
                if (value == _corporationRole) return;
                _corporationRole = value;
                OnPropertyChanged();
            }
        } // TODO check type!

        public Region Region
        {
            get { return _region; }
            internal set
            {
                if (Equals(value, _region)) return;
                _region = value;
                OnPropertyChanged();
            }
        }

        public Constellation Constellation
        {
            get { return _constellation; }
            internal set
            {
                if (Equals(value, _constellation)) return;
                _constellation = value;
                OnPropertyChanged();
            }
        }

        public SolarSystem SolarSystem
        {
            get { return _solarSystem; }
            internal set
            {
                if (Equals(value, _solarSystem)) return;
                _solarSystem = value;
                OnPropertyChanged();
            }
        }

        public Station Station
        {
            get { return _station; }
            internal set
            {
                if (Equals(value, _station)) return;
                _station = value;
                OnPropertyChanged();
            }
        }

        public int WarFactionId
        {
            get { return _warFactionId; }
            internal set
            {
                if (value == _warFactionId) return;
                _warFactionId = value;
                OnPropertyChanged();
            }
        } // TODO What is this?


        public Ship Ship
        {
            get { return _ship; }
            set
            {
                if (Equals(value, _ship)) return;
                _ship = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}