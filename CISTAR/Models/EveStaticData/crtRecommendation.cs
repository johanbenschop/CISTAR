namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crtRecommendation
    {
        [Key]
        public int recommendationID { get; set; }

        public int? shipTypeID { get; set; }

        public int? certificateID { get; set; }

        public byte recommendationLevel { get; set; }
    }
}
