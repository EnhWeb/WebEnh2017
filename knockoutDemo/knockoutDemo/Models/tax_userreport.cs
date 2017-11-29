namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_userreport
    {
        [Key]
        public int URNo { get; set; }

        public int TimeNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int TNo { get; set; }

        [Required]
        [StringLength(10)]
        public string TableType { get; set; }

        public int CaseNo { get; set; }

        public int UTNo { get; set; }

        [StringLength(5)]
        public string HValue { get; set; }

        [StringLength(5)]
        public string LValue { get; set; }

        [StringLength(100)]
        public string AnswerContent { get; set; }

        public DateTime? AddTime { get; set; }

        [StringLength(10)]
        public string RowSpan { get; set; }

        [StringLength(10)]
        public string ColSpan { get; set; }
    }
}
