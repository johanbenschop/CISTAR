namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class staOperationService
    {
        [Key]
        [Column(Order = 0)]
        public byte operationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int serviceID { get; set; }
    }
}
