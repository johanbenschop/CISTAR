namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mapSolarSystem
    {
        public mapSolarSystem()
        {
            chrFactions = new HashSet<chrFaction>();
            crpNPCCorporations = new HashSet<crpNPCCorporation>();
        }

        public int? regionID { get; set; }

        public int? constellationID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int solarSystemID { get; set; }

        [StringLength(100)]
        public string solarSystemName { get; set; }

        public double? x { get; set; }

        public double? y { get; set; }

        public double? z { get; set; }

        public double? xMin { get; set; }

        public double? xMax { get; set; }

        public double? yMin { get; set; }

        public double? yMax { get; set; }

        public double? zMin { get; set; }

        public double? zMax { get; set; }

        public double? luminosity { get; set; }

        public bool? border { get; set; }

        public bool? fringe { get; set; }

        public bool? corridor { get; set; }

        public bool? hub { get; set; }

        public bool? international { get; set; }

        public bool? regional { get; set; }

        public bool? constellation { get; set; }

        public double? security { get; set; }

        public int? factionID { get; set; }

        public double? radius { get; set; }

        public int? sunTypeID { get; set; }

        [StringLength(2)]
        public string securityClass { get; set; }

        public virtual ICollection<chrFaction> chrFactions { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations { get; set; }
    }
}
