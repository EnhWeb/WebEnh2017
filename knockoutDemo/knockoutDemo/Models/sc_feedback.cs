namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_feedback
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(20)]
        public string UserId { get; set; }

        [Required]
        [StringLength(2000)]
        public string Content { get; set; }

        public string FeedbackImages { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactInfo { get; set; }

        public int? CommentStar { get; set; }

        [StringLength(100)]
        public string ClientId { get; set; }

        [StringLength(96)]
        public string UserIpAddress { get; set; }

        public bool? IsHandle { get; set; }

        [StringLength(500)]
        public string ManageRemark { get; set; }

        public DateTime? SendTime { get; set; }
    }
}
