namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_phonecode
    {
        [Key]
        public int PCNo { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string SMSCode { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? OverTime { get; set; }

        [StringLength(25)]
        public string SMSType { get; set; }

        public bool? IsInvalid { get; set; }

        public int? ValidateCount { get; set; }
    }
}
