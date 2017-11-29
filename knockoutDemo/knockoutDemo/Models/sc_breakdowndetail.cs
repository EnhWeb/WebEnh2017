namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_breakdowndetail
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string BdId { get; set; }

        [StringLength(100)]
        public string VoucherNo { get; set; }

        [StringLength(200)]
        public string AbsName { get; set; }

        public decimal? ToMoney { get; set; }

        public decimal? LoadMoney { get; set; }

        [StringLength(10)]
        public string Direct { get; set; }

        public decimal? Remain { get; set; }
    }
}
