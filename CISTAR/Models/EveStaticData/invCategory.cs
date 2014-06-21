namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int categoryID { get; set; }

        [StringLength(100)]
        public string categoryName { get; set; }

        [StringLength(3000)]
        public string description { get; set; }

        public int? iconID { get; set; }

        public bool? published { get; set; }
    }
}
