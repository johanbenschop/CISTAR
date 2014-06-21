namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class agtAgent
    {
        public agtAgent()
        {
            invTypes = new HashSet<invType>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int agentID { get; set; }

        public byte? divisionID { get; set; }

        public int? corporationID { get; set; }

        public int? locationID { get; set; }

        public byte? level { get; set; }

        public short? quality { get; set; }

        public int? agentTypeID { get; set; }

        public bool? isLocator { get; set; }

        public virtual invName invName { get; set; }

        public virtual agtAgentType agtAgentType { get; set; }

        public virtual crpNPCCorporation crpNPCCorporation { get; set; }

        public virtual crpNPCDivision crpNPCDivision { get; set; }

        public virtual ICollection<invType> invTypes { get; set; }
    }
}
