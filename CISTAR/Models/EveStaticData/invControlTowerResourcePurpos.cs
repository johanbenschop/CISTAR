namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("invControlTowerResourcePurposes")]
    public partial class invControlTowerResourcePurpos
    {
        [Key]
        public byte purpose { get; set; }

        [StringLength(100)]
        public string purposeText { get; set; }
    }
}
