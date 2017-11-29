namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_case
    {
        [Key]
        public int CaseNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string TaxType { get; set; }

        public int? CType { get; set; }

        [StringLength(500)]
        public string LogoImg { get; set; }

        [StringLength(500)]
        public string Path { get; set; }

        public int TaxPoint { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string Editer { get; set; }

        public int? States { get; set; }

        [StringLength(20)]
        public string DiscernNumber { get; set; }

        [StringLength(50)]
        public string OrganName { get; set; }

        [StringLength(20)]
        public string SysTime { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [StringLength(20)]
        public string Account { get; set; }
    }
}
