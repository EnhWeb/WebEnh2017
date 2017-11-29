namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_cashrecord
    {
        [StringLength(36)]
        public string Id { get; set; }

        public int? CashType { get; set; }

        [StringLength(10)]
        public string year { get; set; }

        [StringLength(4)]
        public string month { get; set; }

        [StringLength(4)]
        public string day { get; set; }

        [StringLength(100)]
        public string VoucherNo { get; set; }

        [StringLength(500)]
        public string AbsName { get; set; }

        public decimal? ToMoney { get; set; }

        public decimal? LoadMoney { get; set; }

        public decimal? Remain { get; set; }
    }
}
