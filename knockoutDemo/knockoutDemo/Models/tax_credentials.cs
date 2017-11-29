namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_credentials
    {
        [Key]
        public int CNo { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Rate { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string Editer { get; set; }

        public int? States { get; set; }
    }
}
