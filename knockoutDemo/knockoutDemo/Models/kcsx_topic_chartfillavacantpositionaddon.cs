namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topic_chartfillavacantpositionaddon
    {
        public long Id { get; set; }

        public long QueId { get; set; }

        public short SubTopicCount { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string TopicDesignHtml { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string TopicDisplayHtml { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CorrectAnswerHtml { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUserName { get; set; }
    }
}
