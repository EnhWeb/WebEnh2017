namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_usersubjectperiodinitanswerrecord
    {
        [Key]
        [StringLength(18)]
        public string AnsId { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(18)]
        public string CaseId { get; set; }

        [StringLength(18)]
        public string SubjectCode { get; set; }

        public decimal? BorrowAnswer { get; set; }

        public decimal? LoanAnswer { get; set; }

        public DateTime? AnswerTime { get; set; }
    }
}
