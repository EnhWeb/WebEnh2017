namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_case
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string ComId { get; set; }

        [StringLength(36)]
        public string CaseDate { get; set; }

        public int? State { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }

        public int SeqNo { get; set; }

        public int? IsDeleted { get; set; }
    }
}
