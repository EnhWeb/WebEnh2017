namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_loginhistory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(36)]
        public string UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string SessionId { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime LogoutTime { get; set; }
    }
}
