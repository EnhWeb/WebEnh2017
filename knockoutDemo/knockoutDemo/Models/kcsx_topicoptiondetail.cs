namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topicoptiondetail
    {
        public long Id { get; set; }

        public long OptionModelId { get; set; }

        [Required]
        [StringLength(30)]
        public string DisplayName { get; set; }

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
