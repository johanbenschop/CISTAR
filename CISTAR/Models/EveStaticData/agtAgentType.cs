namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class agtAgentType
    {
        public agtAgentType()
        {
            agtAgents = new HashSet<agtAgent>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int agentTypeID { get; set; }

        [StringLength(50)]
        public string agentType { get; set; }

        public virtual ICollection<agtAgent> agtAgents { get; set; }
    }
}
