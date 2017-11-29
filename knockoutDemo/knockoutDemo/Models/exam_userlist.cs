namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exam_userlist
    {
        [StringLength(255)]
        public string Id { get; set; }

        [StringLength(255)]
        public string ExId { get; set; }

        [StringLength(255)]
        public string UserId { get; set; }

        public int? ExState { get; set; }

        [StringLength(255)]
        public string CreateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(255)]
        public string UpdateUser { get; set; }

        public DateTime? Updatetime { get; set; }

        public decimal? Score { get; set; }
    }
}
