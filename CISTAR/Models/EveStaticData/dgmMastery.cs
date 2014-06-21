namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dgmMastery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int masteryID { get; set; }

        public int certificateID { get; set; }

        public byte grade { get; set; }
    }
}
