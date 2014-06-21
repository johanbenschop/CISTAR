namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class staOperation
    {
        public byte? activityID { get; set; }

        [Key]
        public byte operationID { get; set; }

        [StringLength(100)]
        public string operationName { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        public byte? fringe { get; set; }

        public byte? corridor { get; set; }

        public byte? hub { get; set; }

        public byte? border { get; set; }

        public byte? ratio { get; set; }

        public int? caldariStationTypeID { get; set; }

        public int? minmatarStationTypeID { get; set; }

        public int? amarrStationTypeID { get; set; }

        public int? gallenteStationTypeID { get; set; }

        public int? joveStationTypeID { get; set; }
    }
}
