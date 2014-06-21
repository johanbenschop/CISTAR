namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crpActivity
    {
        [Key]
        public byte activityID { get; set; }

        [StringLength(100)]
        public string activityName { get; set; }

        [StringLength(1000)]
        public string description { get; set; }
    }
}
