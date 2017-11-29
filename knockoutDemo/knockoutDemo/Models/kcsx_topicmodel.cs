namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topicmodel
    {
        public short Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        public short SortRank { get; set; }

        [StringLength(255)]
        public string ViewPatch { get; set; }

        [Required]
        [StringLength(64)]
        public string TopicRecordAddOnTableName { get; set; }

        [Required]
        [StringLength(64)]
        public string TopicStandardAnswerTableName { get; set; }

        [Required]
        [StringLength(64)]
        public string TopicUserAnswerTableName { get; set; }

        public DateTime InsertDateTime { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; }
    }
}
