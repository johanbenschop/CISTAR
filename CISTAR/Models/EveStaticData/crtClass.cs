namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crtClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int classID { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        [StringLength(256)]
        public string className { get; set; }
    }
}
