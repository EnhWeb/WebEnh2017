namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_userrole
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(100)]
        public string RoleName { get; set; }

        public DateTime? LastDate { get; set; }

        [MaxLength(36)]
        public byte[] LastEdit { get; set; }
    }
}
