namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_order
    {
        public long Id { get; set; }

        [StringLength(30)]
        public string OrderNo { get; set; }

        public int? PayType { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        public int? OrderStatus { get; set; }

        public DateTime? AddTime { get; set; }

        [StringLength(30)]
        public string DiscountCode { get; set; }

        public decimal? OrderPrice { get; set; }

        [StringLength(255)]
        public string TicketHead { get; set; }

        [StringLength(13)]
        public string Mobile { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(500)]
        public string Address { get; set; }
    }
}
