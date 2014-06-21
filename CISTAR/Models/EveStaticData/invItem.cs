namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int itemID { get; set; }

        public int typeID { get; set; }

        public int ownerID { get; set; }

        public long locationID { get; set; }

        public short flagID { get; set; }

        public int quantity { get; set; }

        public virtual invUniqueName invUniqueName { get; set; }
    }
}
