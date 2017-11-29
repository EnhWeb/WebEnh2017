namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_company
    {
        [StringLength(36)]
        public string Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ComName { get; set; }

        [StringLength(500)]
        public string LogoImg { get; set; }

        [StringLength(500)]
        public string ArtImgUrl { get; set; }

        [StringLength(500)]
        public string BusinessLicenseVpath { get; set; }

        [StringLength(300)]
        public string ComAddress { get; set; }

        [StringLength(36)]
        public string ComArtificial { get; set; }

        [StringLength(100)]
        public string ComBank { get; set; }

        [StringLength(36)]
        public string ComAccount { get; set; }

        [StringLength(36)]
        public string InsId { get; set; }

        [StringLength(36)]
        public string ComCapital { get; set; }

        [StringLength(36)]
        public string TaxNo { get; set; }

        [StringLength(36)]
        public string Tel { get; set; }

        [StringLength(30)]
        public string Taxer { get; set; }

        public DateTime? RegDate { get; set; }

        [StringLength(36)]
        public string AccountManager { get; set; }

        [StringLength(4000)]
        public string Scope { get; set; }

        public int? SeqNo { get; set; }

        public bool? IsEnable { get; set; }

        [StringLength(36)]
        public string CreateUser { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastDate { get; set; }

        public bool? IsDeleted { get; set; }

        public int? ReportType { get; set; }

        [StringLength(4000)]
        public string CasesJson { get; set; }
    }
}
