namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_billingcommoditycode
    {
        public int Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public decimal? Tax { get; set; }

        [StringLength(50)]
        public string SimpleCode { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
