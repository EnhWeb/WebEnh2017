namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_flageducation
    {
        public short Id { get; set; }

        [Required]
        [StringLength(20)]
        public string FlagName { get; set; }

        public short Sort { get; set; }

        public DateTime? InsertDateTime { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsDeleted { get; set; }
    }
}
