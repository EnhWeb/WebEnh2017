namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_breakdown
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string CaseId { get; set; }

        [StringLength(255)]
        public string SubjectCode { get; set; }

        [StringLength(255)]
        public string ParentSubjectCode { get; set; }

        [StringLength(255)]
        public string SubjectName { get; set; }

        [StringLength(255)]
        public string SubjectNamefordiy { get; set; }

        public bool? IsParent { get; set; }

        public int? SubjectLevel { get; set; }

        public int? SeqNo { get; set; }

        [StringLength(255)]
        public string VouchNo { get; set; }

        [StringLength(500)]
        public string AbsName { get; set; }

        public decimal? NowTo { get; set; }

        public decimal? NowLoan { get; set; }

        [StringLength(36)]
        public string Direct { get; set; }

        public decimal? RemainAmount { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
