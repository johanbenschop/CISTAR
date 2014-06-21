namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invType
    {
        public invType()
        {
            chrBloodlines = new HashSet<chrBloodline>();
            agtAgents = new HashSet<agtAgent>();
            crpNPCCorporations = new HashSet<crpNPCCorporation>();
            crpNPCCorporations1 = new HashSet<crpNPCCorporation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int typeID { get; set; }

        public int? groupID { get; set; }

        [StringLength(100)]
        public string typeName { get; set; }

        [StringLength(3000)]
        public string description { get; set; }

        public double? mass { get; set; }

        public double? volume { get; set; }

        public double? capacity { get; set; }

        public int? portionSize { get; set; }

        public byte? raceID { get; set; }

        [Column(TypeName = "money")]
        public decimal? basePrice { get; set; }

        public bool? published { get; set; }

        public int? marketGroupID { get; set; }

        public double? chanceOfDuplicating { get; set; }

        public int? factionID { get; set; }

        public int? graphicID { get; set; }

        public int? iconID { get; set; }

        public double? radius { get; set; }

        public int? soundID { get; set; }

        public virtual ICollection<chrBloodline> chrBloodlines { get; set; }

        public virtual ICollection<agtAgent> agtAgents { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations { get; set; }

        public virtual ICollection<crpNPCCorporation> crpNPCCorporations1 { get; set; }
    }
}
