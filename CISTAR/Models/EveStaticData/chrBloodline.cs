namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class chrBloodline
    {
        [Key]
        public byte bloodlineID { get; set; }

        [StringLength(100)]
        public string bloodlineName { get; set; }

        public byte? raceID { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        [StringLength(1000)]
        public string maleDescription { get; set; }

        [StringLength(1000)]
        public string femaleDescription { get; set; }

        public int? shipTypeID { get; set; }

        public int? corporationID { get; set; }

        public byte? perception { get; set; }

        public byte? willpower { get; set; }

        public byte? charisma { get; set; }

        public byte? memory { get; set; }

        public byte? intelligence { get; set; }

        public int? iconID { get; set; }

        [StringLength(500)]
        public string shortDescription { get; set; }

        [StringLength(500)]
        public string shortMaleDescription { get; set; }

        [StringLength(500)]
        public string shortFemaleDescription { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation { get; set; }

        public virtual invType invType { get; set; }
    }
}
