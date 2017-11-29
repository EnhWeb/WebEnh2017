namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_class
    {
        [Key]
        public int ClassNo { get; set; }

        public int TieNo { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
