namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_userlook
    {
        [Key]
        public int ULNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int CaseNo { get; set; }

        public int TNo { get; set; }

        public int TimeNo { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
