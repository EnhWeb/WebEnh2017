namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_app_refreshtokens
    {
        [StringLength(200)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        public DateTime? IssuedUtc { get; set; }

        public DateTime? ExpiresUtc { get; set; }

        [StringLength(2550)]
        public string ProtectedTicket { get; set; }
    }
}
