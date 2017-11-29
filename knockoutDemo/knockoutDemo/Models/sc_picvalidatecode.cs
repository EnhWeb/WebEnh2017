namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_picvalidatecode
    {
        public long Id { get; set; }

        [StringLength(150)]
        public string ValidateCodeKey { get; set; }

        [StringLength(4)]
        public string ValidateCode { get; set; }

        [StringLength(20)]
        public string ValidateCodeType { get; set; }

        [StringLength(96)]
        public string ClientIp { get; set; }

        public int? ValidateCount { get; set; }

        public bool? IsInvalid { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? OverTime { get; set; }
    }
}
