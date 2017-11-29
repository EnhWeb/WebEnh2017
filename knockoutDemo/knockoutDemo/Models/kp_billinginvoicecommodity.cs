namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_billinginvoicecommodity
    {
        public int ID { get; set; }

        public int InvoiceID { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int? CommodityID { get; set; }

        [StringLength(50)]
        public string Sku { get; set; }

        [StringLength(50)]
        public string Util { get; set; }

        public int? Count { get; set; }

        public decimal? Price { get; set; }

        public decimal? Tax { get; set; }

        [StringLength(50)]
        public string GoodName { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
