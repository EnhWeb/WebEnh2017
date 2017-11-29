namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topic_chartfillavacantpositionansuser
    {
        public long Id { get; set; }

        public long TaskId { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        public long QueId { get; set; }

        [Required]
        [StringLength(4000)]
        public string UserAswer { get; set; }

        public short SubTopicCorrectCount { get; set; }

        public short SubTopicErrorCount { get; set; }

        [Required]
        [StringLength(4000)]
        public string FirstUserAnswer { get; set; }

        public short FirstSubTopicCorrectCount { get; set; }

        public short FirstSubTopicErrorCount { get; set; }

        public DateTime FirstSubmitTime { get; set; }

        public DateTime CreateTime { get; set; }

        public short UpdateCount { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
