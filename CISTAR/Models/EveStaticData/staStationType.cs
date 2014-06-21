namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class staStationType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stationTypeID { get; set; }

        public double? dockEntryX { get; set; }

        public double? dockEntryY { get; set; }

        public double? dockEntryZ { get; set; }

        public double? dockOrientationX { get; set; }

        public double? dockOrientationY { get; set; }

        public double? dockOrientationZ { get; set; }

        public byte? operationID { get; set; }

        public byte? officeSlots { get; set; }

        public double? reprocessingEfficiency { get; set; }

        public bool? conquerable { get; set; }
    }
}
