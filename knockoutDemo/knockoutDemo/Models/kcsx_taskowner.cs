namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_taskowner
    {
        public long Id { get; set; }

        public long TaskId { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        public short StatisticalState { get; set; }

        public bool IsStarted { get; set; }

        public bool IsEnded { get; set; }

        public DateTime? StartedTime { get; set; }

        public DateTime? SubmitEndTime { get; set; }

        public int? TimeSpan { get; set; }

        public short? TaskScore { get; set; }

        public short? UserCompletionCount { get; set; }

        public short? UserCorrectCount { get; set; }

        public int? ClassNo { get; set; }
    }
}
