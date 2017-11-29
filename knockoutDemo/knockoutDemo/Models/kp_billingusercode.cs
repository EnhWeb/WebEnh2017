namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_billingusercode
    {
        public int Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string CustomerNum { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(2000)]
        public string Address { get; set; }

        [StringLength(255)]
        public string BankAccount { get; set; }

        [StringLength(255)]
        public string ParentCode { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
