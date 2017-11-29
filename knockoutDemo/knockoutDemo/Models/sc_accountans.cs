namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accountans
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(18)]
        public string QueId { get; set; }

        public decimal? ToMoney { get; set; }

        public decimal? LoanMoney { get; set; }

        [StringLength(200)]
        public string SubjectCode { get; set; }

        [StringLength(20)]
        public string ParentSubjectCode { get; set; }

        [StringLength(200)]
        public string SubjectName { get; set; }

        [StringLength(200)]
        public string SubjectNameForDiy { get; set; }

        [StringLength(50)]
        public string SubjectLevelOneName { get; set; }

        public int? SubjectLevel { get; set; }

        public bool? IsParent { get; set; }

        public DateTime? LastDate { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }
    }
}
