namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topictype
    {
        public long Id { get; set; }

        public long ReId { get; set; }

        public long TopId { get; set; }

        public short Level { get; set; }

        public short SortRank { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }

        [StringLength(500)]
        public string CoverPhoto { get; set; }

        public bool? IsPublic { get; set; }

        public bool IsParent { get; set; }

        [StringLength(50)]
        public string FlagEducationIds { get; set; }

        public bool ShowContent { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public DateTime AddDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string AddUserName { get; set; }

        public DateTime UpdateDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUserName { get; set; }

        public bool IsEnabled { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
