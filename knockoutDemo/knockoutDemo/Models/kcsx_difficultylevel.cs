namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_difficultylevel
    {
        [Key]
        public short DifficultyLevelId { get; set; }

        [StringLength(10)]
        public string DifficultyName { get; set; }
    }
}
