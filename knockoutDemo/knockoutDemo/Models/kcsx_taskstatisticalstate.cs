namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_taskstatisticalstate
    {
        public short Id { get; set; }

        [StringLength(50)]
        public string StatisticalStateName { get; set; }

        [StringLength(20)]
        public string Color { get; set; }
    }
}
