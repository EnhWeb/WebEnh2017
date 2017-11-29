namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_taskuseranswerstate
    {
        public short Id { get; set; }

        [StringLength(20)]
        public string StateName { get; set; }

        [StringLength(20)]
        public string DisplayName { get; set; }

        [StringLength(20)]
        public string StateTextColor { get; set; }

        [StringLength(500)]
        public string StateImagePath { get; set; }
    }
}
