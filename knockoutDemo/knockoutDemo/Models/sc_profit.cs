namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_profit
    {
        public int Id { get; set; }

        [StringLength(18)]
        public string CaseId { get; set; }

        public int? ItemId { get; set; }

        public decimal? PreSum { get; set; }

        public decimal? MonthSum { get; set; }

        public decimal? YearSum { get; set; }
    }
}
