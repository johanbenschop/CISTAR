namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ramAssemblyLineType
    {
        [Key]
        public byte assemblyLineTypeID { get; set; }

        [StringLength(100)]
        public string assemblyLineTypeName { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        public double? baseTimeMultiplier { get; set; }

        public double? baseMaterialMultiplier { get; set; }

        public double? volume { get; set; }

        public byte? activityID { get; set; }

        public double? minCostPerHour { get; set; }
    }
}
