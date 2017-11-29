namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accountansusermanual
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(18)]
        public string QueId { get; set; }

        [StringLength(200)]
        public string UserAnswerAbsname { get; set; }

        [StringLength(200)]
        public string UserAnswerSubjectName { get; set; }

        [StringLength(50)]
        public string UserAnswerSubjectLevelOneName { get; set; }

        public decimal? UserAnswerToMoney { get; set; }

        public decimal? UserAnswerLoanMoney { get; set; }

        public DateTime? UserAnswerLastUpdateDateTime { get; set; }

        public DateTime? UserAnswerCreateDateTime { get; set; }
    }
}
