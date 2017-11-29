namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topic_objectivequestionaddon
    {
        public long Id { get; set; }

        public long QueId { get; set; }

        public long? SelectTypeModelId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string SelectItemsJson { get; set; }

        [Required]
        [StringLength(20)]
        public string CorrectSelect { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUserName { get; set; }
    }
}
