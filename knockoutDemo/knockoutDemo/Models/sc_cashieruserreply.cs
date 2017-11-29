namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_cashieruserreply
    {
        [Key]
        public int URNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        public int TopicNo { get; set; }

        public DateTime? AddTime { get; set; }

        public int HasCorrect { get; set; }

        public int FirstHasCorrect { get; set; }
    }
}
