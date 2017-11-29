namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_industry
    {
        [StringLength(20)]
        public string Id { get; set; }

        [Required]
        [StringLength(20)]
        public string IndustryName { get; set; }

        [StringLength(255)]
        public string FilePath { get; set; }

        [StringLength(255)]
        public string FilePath1 { get; set; }

        [StringLength(255)]
        public string FilePath2 { get; set; }

        public int? SeqNo { get; set; }

        public bool? IsEnable { get; set; }

        [StringLength(50)]
        public string CreateUser { get; set; }

        [StringLength(50)]
        public string LastUpdateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
