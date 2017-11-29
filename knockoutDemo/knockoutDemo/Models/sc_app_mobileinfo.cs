namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_app_mobileinfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(10)]
        public string OperaterType { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string MobileClientId { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        public DateTime OccurTime { get; set; }
    }
}
