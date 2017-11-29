namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_subject
    {
        public long Id { get; set; }

        [StringLength(18)]
        public string CompanyID { get; set; }

        [StringLength(20)]
        public string ParentNodeID { get; set; }

        [StringLength(20)]
        public string NodeID { get; set; }

        public int? Level { get; set; }

        public bool? IsParent { get; set; }

        [StringLength(120)]
        public string SubjectName { get; set; }

        [StringLength(120)]
        public string SubjectNameForDiy { get; set; }

        public decimal? AmountBorrow { get; set; }

        public decimal? AmountLoan { get; set; }

        [StringLength(2)]
        public string DirectRule { get; set; }

        [StringLength(2)]
        public string DirectCalc { get; set; }

        [StringLength(10)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
