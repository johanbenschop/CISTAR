namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class invBlueprintType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int blueprintTypeID { get; set; }

        public int? parentBlueprintTypeID { get; set; }

        public int? productTypeID { get; set; }

        public int? productionTime { get; set; }

        public short? techLevel { get; set; }

        public int? researchProductivityTime { get; set; }

        public int? researchMaterialTime { get; set; }

        public int? researchCopyTime { get; set; }

        public int? researchTechTime { get; set; }

        public int? productivityModifier { get; set; }

        public short? materialModifier { get; set; }

        public short? wasteFactor { get; set; }

        public int? maxProductionLimit { get; set; }
    }
}
