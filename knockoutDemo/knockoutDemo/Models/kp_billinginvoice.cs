namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_billinginvoice
    {
        public int Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string InvoiceCode { get; set; }

        [StringLength(50)]
        public string InvoiceNum { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string CustomerNum { get; set; }

        [StringLength(2000)]
        public string Address { get; set; }

        [StringLength(255)]
        public string BankAccount { get; set; }

        public int? CommodityID { get; set; }

        [StringLength(50)]
        public string Sku { get; set; }

        [StringLength(50)]
        public string Util { get; set; }

        public int? Count { get; set; }

        public decimal? Price { get; set; }

        public decimal? Tax { get; set; }

        public DateTime? AddTime { get; set; }

        public int? Status { get; set; }

        public int? InvoiceType { get; set; }

        public bool? IsRed { get; set; }

        public bool? IsVAT { get; set; }

        public bool? IsRedUpdate { get; set; }

        public bool? IsNormalUpdate { get; set; }

        public bool? IsClear { get; set; }

        [StringLength(50)]
        public string GoodName { get; set; }

        [StringLength(50)]
        public string InformationAccount { get; set; }

        [StringLength(50)]
        public string InformationCode { get; set; }

        [StringLength(200)]
        public string Password { get; set; }
    }
}
