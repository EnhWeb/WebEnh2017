namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accountansgeneralledgermanual
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(18)]
        public string QueId { get; set; }

        [StringLength(255)]
        public string SubjectId { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        [StringLength(50)]
        public string VoucherNumber { get; set; }

        [StringLength(200)]
        public string UserAnswerAbsname { get; set; }

        public decimal? UserAnswerBrowerMoney { get; set; }

        public decimal? UserAnswerLoanMoney { get; set; }

        [StringLength(2)]
        public string UserLoanType { get; set; }

        public decimal? Balance { get; set; }

        public DateTime? UserAnswerLastUpdateDateTime { get; set; }

        public DateTime? UserAnswerCreateDateTime { get; set; }
    }
}
