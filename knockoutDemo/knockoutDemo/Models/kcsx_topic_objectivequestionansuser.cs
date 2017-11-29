namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topic_objectivequestionansuser
    {
        public long Id { get; set; }

        public long TaskId { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        public long QueId { get; set; }

        [StringLength(255)]
        public string Aswer { get; set; }

        [StringLength(255)]
        public string FirstAnswer { get; set; }

        public DateTime? FirstSubmitTime { get; set; }

        public DateTime? CreateTime { get; set; }

        public short? UpdateCount { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
