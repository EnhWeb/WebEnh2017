namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_subjectremain
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(20)]
        public string CaseId { get; set; }

        [StringLength(20)]
        public string ParentSubjectCode { get; set; }

        [StringLength(20)]
        public string SubjectCode { get; set; }

        [StringLength(200)]
        public string SubjectName { get; set; }

        [StringLength(200)]
        public string SubjectNameForDiy { get; set; }

        public int? SubjectLevel { get; set; }

        public bool? IsParent { get; set; }

        public int? SeqNo { get; set; }

        [StringLength(2)]
        public string DirectRule { get; set; }

        [StringLength(2)]
        public string DirectPreCalc { get; set; }

        [StringLength(2)]
        public string DirectRemainCalc { get; set; }

        public decimal? AmountPreBorrow { get; set; }

        public decimal? AmountPreLoan { get; set; }

        public decimal? AmountNowBorrow { get; set; }

        public decimal? AmountNowLoan { get; set; }

        public decimal? AmountRemainBorrow { get; set; }

        public decimal? AmountRemainLoan { get; set; }

        public DateTime? Lastdate { get; set; }

        [StringLength(12)]
        public string Lastedit { get; set; }
    }
}
