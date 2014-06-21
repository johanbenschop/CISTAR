namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class crpNPCDivision
    {
        public crpNPCDivision()
        {
            agtAgents = new HashSet<agtAgent>();
            crpNPCCorporationDivisions = new HashSet<crpNPCCorporationDivision>();
        }

        [Key]
        public byte divisionID { get; set; }

        [StringLength(100)]
        public string divisionName { get; set; }

        [StringLength(1000)]
        public string description { get; set; }

        [StringLength(100)]
        public string leaderType { get; set; }

        public virtual ICollection<agtAgent> agtAgents { get; set; }

        public virtual ICollection<crpNPCCorporationDivision> crpNPCCorporationDivisions { get; set; }
    }
}
