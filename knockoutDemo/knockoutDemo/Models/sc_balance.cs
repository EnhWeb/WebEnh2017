namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_balance
    {
        public int Id { get; set; }

        [StringLength(36)]
        public string CaseId { get; set; }

        public int? ItemId { get; set; }

        public decimal? Beginning { get; set; }

        public decimal? Ending { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
