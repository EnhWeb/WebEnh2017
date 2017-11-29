namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exam_exname
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(255)]
        public string CaseId { get; set; }

        [StringLength(50)]
        public string SchoolId { get; set; }

        [StringLength(255)]
        public string ExName { get; set; }

        public DateTime? Starttime { get; set; }

        public DateTime? Endtime { get; set; }

        public decimal? Duration { get; set; }

        [StringLength(255)]
        public string Createuser { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
