namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_taskownerdetail
    {
        public long Id { get; set; }

        public long TaskId { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        public long QueId { get; set; }

        public short UserAnswerStateId { get; set; }

        public short? SubTaskScore { get; set; }

        public bool IsCorrect { get; set; }

        public bool IsFirstEnter { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? FirstSubmitTime { get; set; }

        public DateTime? LastSubmitTime { get; set; }
    }
}
