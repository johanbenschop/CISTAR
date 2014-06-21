namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ramAssemblyLineStation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stationID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte assemblyLineTypeID { get; set; }

        public byte? quantity { get; set; }

        public int? stationTypeID { get; set; }

        public int? ownerID { get; set; }

        public int? solarSystemID { get; set; }

        public int? regionID { get; set; }
    }
}
