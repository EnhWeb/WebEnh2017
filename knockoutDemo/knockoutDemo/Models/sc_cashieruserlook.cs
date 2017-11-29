namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_cashieruserlook
    {
        [Key]
        public int ULNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int TopicNo { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
