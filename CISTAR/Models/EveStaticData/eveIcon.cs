namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class eveIcon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iconID { get; set; }

        [Required]
        [StringLength(500)]
        public string iconFile { get; set; }

        [Required]
        public string description { get; set; }
    }
}
