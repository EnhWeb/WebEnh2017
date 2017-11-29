namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_school
    {
        [StringLength(20)]
        public string Id { get; set; }

        [Required]
        [StringLength(200)]
        public string SchoolFullName { get; set; }

        [StringLength(100)]
        public string SchoolName { get; set; }

        [StringLength(36)]
        public string SchoolCode { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastDate { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }
    }
}
