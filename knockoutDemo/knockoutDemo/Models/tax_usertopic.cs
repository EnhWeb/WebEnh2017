namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_usertopic
    {
        [Key]
        public int UTNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int TNo { get; set; }

        public int CaseNo { get; set; }

        public int TimeNo { get; set; }

        [StringLength(10)]
        public string Quarter { get; set; }

        [StringLength(10)]
        public string Year { get; set; }

        [StringLength(10)]
        public string Month { get; set; }

        [StringLength(10)]
        public string TaxType { get; set; }

        [StringLength(10)]
        public string TableType { get; set; }

        public int? TimeType { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        public int? HasCorrect { get; set; }

        public int? FirstHasCorrect { get; set; }

        public int? VersionNo { get; set; }

        public int? DeclareState { get; set; }

        public int? TaxState { get; set; }

        [StringLength(20)]
        public string DeclareTime { get; set; }

        [StringLength(20)]
        public string TaxTime { get; set; }

        public int? WriteState { get; set; }
    }
}
