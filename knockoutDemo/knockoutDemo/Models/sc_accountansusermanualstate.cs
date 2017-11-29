namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accountansusermanualstate
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(36)]
        public string QueId { get; set; }

        public int? AnsState { get; set; }
    }
}
