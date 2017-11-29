namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_taskuserlogs
    {
        public long Id { get; set; }

        public long? TaskId { get; set; }

        [Required]
        [StringLength(5)]
        public string UserType { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        public long? QueId { get; set; }

        [Required]
        [StringLength(100)]
        public string OperaterType { get; set; }

        [Required]
        [StringLength(255)]
        public string OperaterContent { get; set; }

        public DateTime OperaterTime { get; set; }

        public bool IsDeleted { get; set; }
    }
}
