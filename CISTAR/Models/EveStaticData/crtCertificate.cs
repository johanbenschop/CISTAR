namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crtCertificate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int certificateID { get; set; }

        public short? groupID { get; set; }

        public int? classID { get; set; }

        public byte? grade { get; set; }

        public int? corpID { get; set; }

        public int? iconID { get; set; }

        [StringLength(500)]
        public string description { get; set; }
    }
}
