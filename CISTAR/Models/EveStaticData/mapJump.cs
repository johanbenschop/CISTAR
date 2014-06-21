namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mapJump
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stargateID { get; set; }

        public int? celestialID { get; set; }
    }
}
