namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topicoptionmodel
    {
        public long Id { get; set; }

        public short TopicModelId { get; set; }

        [Required]
        [StringLength(50)]
        public string OptionModelName { get; set; }

        [StringLength(255)]
        public string Desc { get; set; }

        public short SortRank { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(20)]
        public string CreateUserName { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(20)]
        public string UpdateUserName { get; set; }

        public bool IsDeleted { get; set; }
    }
}
