namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_cashierseal
    {
        [Key]
        public int SealNo { get; set; }

        [Required]
        [StringLength(200)]
        public string ImgPath { get; set; }

        public int? Sort { get; set; }

        public int? States { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string Editer { get; set; }
    }
}
