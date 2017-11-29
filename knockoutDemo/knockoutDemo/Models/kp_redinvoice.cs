namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_redinvoice
    {
        public int ID { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public DateTime AddTime { get; set; }

        [Required]
        [StringLength(32)]
        public string Code { get; set; }
    }
}
