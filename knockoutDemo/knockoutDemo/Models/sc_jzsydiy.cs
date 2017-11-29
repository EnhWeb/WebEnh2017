namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_jzsydiy
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(36)]
        public string QueId { get; set; }

        public decimal? ToMoney { get; set; }

        public decimal? LoanMoney { get; set; }

        public int? SeqNo { get; set; }

        [StringLength(20)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }

        [StringLength(200)]
        public string SubjectLevelOneName { get; set; }

        [StringLength(20)]
        public string SubjectCode { get; set; }
    }
}
