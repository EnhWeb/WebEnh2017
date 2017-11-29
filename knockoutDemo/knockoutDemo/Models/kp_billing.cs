namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_billing
    {
        public int Id { get; set; }

        public int? Step { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? Sort { get; set; }

        [StringLength(2000)]
        public string Answer { get; set; }

        public int? ControlType { get; set; }

        [StringLength(255)]
        public string ControlValue { get; set; }

        public DateTime? AddTime { get; set; }

        public int? GroupID { get; set; }

        public bool? IsCheck { get; set; }

        public bool? IsShow { get; set; }
    }
}
