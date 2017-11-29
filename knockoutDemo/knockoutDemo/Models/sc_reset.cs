namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_reset
    {
        public long Id { get; set; }

        [Required]
        [StringLength(32)]
        public string UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string ResetType { get; set; }

        public long ContentId { get; set; }

        public int ResetDataCount { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string ResetDataJsonBackup { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RunSql { get; set; }

        public bool OperaterState { get; set; }

        [Required]
        [StringLength(255)]
        public string OperaterResult { get; set; }

        public DateTime ResetTime { get; set; }
    }
}
