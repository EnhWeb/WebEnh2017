namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_topic
    {
        [Key]
        public int TNo { get; set; }

        public int CaseNo { get; set; }

        public int TimeNo { get; set; }

        [Required]
        [StringLength(10)]
        public string TaxType { get; set; }

        [StringLength(10)]
        public string TableType { get; set; }

        public int? TimeType { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? Sort { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string Editer { get; set; }

        public int? States { get; set; }

        public int? VersionNo { get; set; }
    }
}
