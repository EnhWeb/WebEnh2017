namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_usertype
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string TypeName { get; set; }

        [StringLength(500)]
        public string TypeDesc { get; set; }

        public DateTime? LastDate { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }
    }
}
