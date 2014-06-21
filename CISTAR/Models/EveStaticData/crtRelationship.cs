namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crtRelationship
    {
        [Key]
        public int relationshipID { get; set; }

        public int? parentID { get; set; }

        public int? parentTypeID { get; set; }

        public byte? parentLevel { get; set; }

        public int? childID { get; set; }

        public byte? grade { get; set; }
    }
}
