namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_userquarter
    {
        [Key]
        public int UQNo { get; set; }

        [StringLength(30)]
        public string TimeNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int CaseNo { get; set; }

        [StringLength(10)]
        public string Year { get; set; }

        [StringLength(10)]
        public string Quarter { get; set; }

        [StringLength(10)]
        public string TaxType { get; set; }

        [StringLength(10)]
        public string TableType { get; set; }

        public DateTime? AddTime { get; set; }

        public int? HasCorrect { get; set; }
    }
}
