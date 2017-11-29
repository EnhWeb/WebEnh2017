namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_task
    {
        public long Id { get; set; }

        [Required]
        [StringLength(36)]
        public string CreateUserId { get; set; }

        public short TaskTypeId { get; set; }

        public long? TopicTypeTopId { get; set; }

        [StringLength(18)]
        public string SchoolId { get; set; }

        public int? TieNo { get; set; }

        [StringLength(255)]
        public string ClassIds { get; set; }

        public short State { get; set; }

        public bool IsExam { get; set; }

        public bool IsReadOnly { get; set; }

        [Required]
        [StringLength(255)]
        public string TaskName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal TimeSpan { get; set; }

        public short QueCount { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(50)]
        public string UpdateUserName { get; set; }
    }
}
