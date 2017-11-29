namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_onepersonpneaccountsupport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ClientID { get; set; }

        [StringLength(96)]
        public string ClientIP { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(4000)]
        public string BrowserInfo { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
