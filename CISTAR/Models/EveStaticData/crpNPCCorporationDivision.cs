namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crpNPCCorporationDivision
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int corporationID { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte divisionID { get; set; }

        public byte? size { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation { get; set; }

        public virtual crpNPCDivision crpNPCDivision { get; set; }
    }
}
