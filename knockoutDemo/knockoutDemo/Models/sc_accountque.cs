namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accountque
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(18)]
        public string CaseId { get; set; }

        public int? IsCarryOver { get; set; }

        public DateTime? FileDate { get; set; }

        [StringLength(500)]
        public string QueDesc { get; set; }

        [StringLength(100)]
        public string AbsName { get; set; }

        [StringLength(1000)]
        public string Anlysisi { get; set; }

        [StringLength(10)]
        public string VoucherNo { get; set; }

        public DateTime? LastDate { get; set; }

        [StringLength(20)]
        public string LastEdit { get; set; }

        public int? SeqNo { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
