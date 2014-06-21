namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class warCombatZone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int combatZoneID { get; set; }

        [StringLength(100)]
        public string combatZoneName { get; set; }

        public int? factionID { get; set; }

        public int? centerSystemID { get; set; }

        [StringLength(500)]
        public string description { get; set; }
    }
}
