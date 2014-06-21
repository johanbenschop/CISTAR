namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crpNPCCorporation
    {
        public crpNPCCorporation()
        {
            agtAgents = new HashSet<agtAgent>();
            chrBloodlines = new HashSet<chrBloodline>();
            chrFactions = new HashSet<chrFaction>();
            chrFactions1 = new HashSet<chrFaction>();
            crpNPCCorporationDivisions = new HashSet<crpNPCCorporationDivision>();
            crpNPCCorporations1 = new HashSet<crpNPCCorporation>();
            crpNPCCorporations11 = new HashSet<crpNPCCorporation>();
            crpNPCCorporations12 = new HashSet<crpNPCCorporation>();
            crpNPCCorporations13 = new HashSet<crpNPCCorporation>();
            crpNPCCorporations14 = new HashSet<crpNPCCorporation>();
            crpNPCCorporations15 = new HashSet<crpNPCCorporation>();
            invTypes = new HashSet<invType>();
            invTypes1 = new HashSet<invType>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corporationID { get; set; }

        [StringLength(1)]
        public string size { get; set; }

        [StringLength(1)]
        public string extent { get; set; }

        public int? solarSystemID { get; set; }

        public int? investorID1 { get; set; }

        public byte? investorShares1 { get; set; }

        public int? investorID2 { get; set; }

        public byte? investorShares2 { get; set; }

        public int? investorID3 { get; set; }

        public byte? investorShares3 { get; set; }

        public int? investorID4 { get; set; }

        public byte? investorShares4 { get; set; }

        public int? friendID { get; set; }

        public int? enemyID { get; set; }

        public long? publicShares { get; set; }

        public int? initialPrice { get; set; }

        public double? minSecurity { get; set; }

        public bool? scattered { get; set; }

        public byte? fringe { get; set; }

        public byte? corridor { get; set; }

        public byte? hub { get; set; }

        public byte? border { get; set; }

        public int? factionID { get; set; }

        public double? sizeFactor { get; set; }

        public short? stationCount { get; set; }

        public short? stationSystemCount { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public int? iconID { get; set; }

        public virtual ICollection<agtAgent> agtAgents { get; set; }

        public virtual ICollection<chrBloodline> chrBloodlines { get; set; }

        public virtual ICollection<chrFaction> chrFactions { get; set; }

        public virtual ICollection<chrFaction> chrFactions1 { get; set; }

        public virtual ICollection<crpNPCCorporationDivision> crpNPCCorporationDivisions { get; set; }

        public virtual invName invName { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations1 { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation1 { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations11 { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation2 { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations12 { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation3 { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations13 { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation4 { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations14 { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation5 { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations15 { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation6 { get; set; }

        public virtual mapSolarSystem mapSolarSystem { get; set; }

        public virtual ICollection<invType> invTypes { get; set; }

        public virtual ICollection<invType> invTypes1 { get; set; }
    }
}
