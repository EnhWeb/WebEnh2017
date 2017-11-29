namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_useraddress
    {
        public int Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(10)]
        public string Province { get; set; }

        [StringLength(10)]
        public string City { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(13)]
        public string Mobile { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
