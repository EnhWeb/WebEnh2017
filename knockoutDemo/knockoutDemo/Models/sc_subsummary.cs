namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_subsummary
    {
        public long Id { get; set; }

        [StringLength(36)]
        public string Caseid { get; set; }

        [StringLength(36)]
        public string Subjectname { get; set; }

        public decimal? PreMonery { get; set; }

        public decimal? NowToMoney { get; set; }

        public decimal? NowLoanMoney { get; set; }

        public decimal? RemainMoney { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
