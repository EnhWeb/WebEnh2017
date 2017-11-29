namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_tie
    {
        [Key]
        public int TieNo { get; set; }

        [Required]
        [StringLength(20)]
        public string SchoolNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string Editer { get; set; }
    }
}
