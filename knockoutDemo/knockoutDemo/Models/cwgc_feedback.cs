namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cwgc_feedback
    {
        public int id { get; set; }

        public int aid { get; set; }

        public short typeid { get; set; }

        [Required]
        [StringLength(20)]
        public string username { get; set; }

        [Required]
        [StringLength(60)]
        public string arctitle { get; set; }

        [Required]
        [StringLength(100)]
        public string ip { get; set; }

        public short ischeck { get; set; }

        public int dtime { get; set; }

        public int mid { get; set; }

        public int bad { get; set; }

        public int good { get; set; }

        [Required]
        [StringLength(17)]
        public string ftype { get; set; }

        public short face { get; set; }

        [Column(TypeName = "text")]
        public string msg { get; set; }
    }
}
