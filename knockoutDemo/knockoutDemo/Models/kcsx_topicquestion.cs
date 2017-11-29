namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topicquestion
    {
        public long Id { get; set; }

        public long NodeId { get; set; }

        public short ModelId { get; set; }

        public short DifficultyLevelId { get; set; }

        public short Score { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Tips { get; set; }

        [StringLength(4000)]
        public string PicContent { get; set; }

        [StringLength(5000)]
        public string Content { get; set; }

        public short SortRank { get; set; }

        [Required]
        [StringLength(4000)]
        public string AnswerAnalysis { get; set; }

        public bool IsEnabled { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(50)]
        public string UpdateUserName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
