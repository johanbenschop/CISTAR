namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invContrabandType
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int factionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int typeID { get; set; }

        public double? standingLoss { get; set; }

        public double? confiscateMinSec { get; set; }

        public double? fineByValue { get; set; }

        public double? attackMinSec { get; set; }
    }
}
