namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_collection
    {
        public int id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(36)]
        public string QueId { get; set; }

        public int? type { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
