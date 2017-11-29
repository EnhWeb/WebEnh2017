namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_companytaxitems
    {
        [StringLength(20)]
        public string Id { get; set; }

        [Required]
        [StringLength(36)]
        public string CompanyId { get; set; }

        [Required]
        [StringLength(100)]
        public string TaxName { get; set; }

        [StringLength(36)]
        public string TaxRate { get; set; }

        [StringLength(200)]
        public string CalcMethod { get; set; }

        [StringLength(255)]
        public string PaymentTaxMethod { get; set; }

        [StringLength(200)]
        public string TaxDesc { get; set; }

        public bool? IsEnable { get; set; }

        public int? SortId { get; set; }

        [StringLength(36)]
        public string CreateUser { get; set; }

        [StringLength(36)]
        public string LastUpdateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
