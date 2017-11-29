namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_taccount_user
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(18)]
        public string CaseId { get; set; }

        [StringLength(36)]
        public string SubjectName { get; set; }

        [StringLength(100)]
        public string VoucherNo { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string Direct { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        public int? RowIndex { get; set; }
    }
}
