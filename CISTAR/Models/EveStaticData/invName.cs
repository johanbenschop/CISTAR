namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int itemID { get; set; }

        [Required]
        [StringLength(200)]
        public string itemName { get; set; }

        public virtual agtAgent agtAgent { get; set; }

        public virtual chrFaction chrFaction { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation { get; set; }
    }
}
