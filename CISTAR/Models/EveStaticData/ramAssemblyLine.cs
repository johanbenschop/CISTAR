namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ramAssemblyLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int assemblyLineID { get; set; }

        public byte? assemblyLineTypeID { get; set; }

        public int? containerID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? nextFreeTime { get; set; }

        public byte? UIGroupingID { get; set; }

        public double? costInstall { get; set; }

        public double? costPerHour { get; set; }

        public byte? restrictionMask { get; set; }

        public double? discountPerGoodStandingPoint { get; set; }

        public double? surchargePerBadStandingPoint { get; set; }

        public double? minimumStanding { get; set; }

        public double? minimumCharSecurity { get; set; }

        public double? minimumCorpSecurity { get; set; }

        public double? maximumCharSecurity { get; set; }

        public double? maximumCorpSecurity { get; set; }

        public int? ownerID { get; set; }

        public byte? activityID { get; set; }
    }
}
