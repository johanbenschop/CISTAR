namespace CISTAR.Models.EveStaticData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class trnTranslationLanguage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numericLanguageID { get; set; }

        [StringLength(50)]
        public string languageID { get; set; }

        [StringLength(200)]
        public string languageName { get; set; }
    }
}
