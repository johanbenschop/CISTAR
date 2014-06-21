namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long itemID { get; set; }

        public double x { get; set; }

        public double y { get; set; }

        public double z { get; set; }

        public float? yaw { get; set; }

        public float? pitch { get; set; }

        public float? roll { get; set; }
    }
}
