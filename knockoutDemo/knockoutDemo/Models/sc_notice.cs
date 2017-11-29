namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_notice
    {
        public int id { get; set; }

        [StringLength(255)]
        public string url { get; set; }

        [StringLength(500)]
        public string content { get; set; }

        public DateTime? date { get; set; }

        public int? deletestate { get; set; }

        public int? Readstate { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }

        public int? state { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }
    }
}
