namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tax_answer
    {
        [Key]
        public int ANo { get; set; }

        public int TNo { get; set; }

        public int CaseNo { get; set; }

        [StringLength(10)]
        public string WZNo { get; set; }

        [StringLength(10)]
        public string HNo { get; set; }

        [StringLength(5)]
        public string HValue { get; set; }

        [StringLength(10)]
        public string LNo { get; set; }

        [StringLength(5)]
        public string LValue { get; set; }

        public int? HasJudge { get; set; }

        [StringLength(100)]
        public string AnswerContent { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        [StringLength(50)]
        public string Adder { get; set; }

        [StringLength(50)]
        public string Editer { get; set; }

        [StringLength(20)]
        public string Special { get; set; }

        public int TimeNo { get; set; }

        [StringLength(20)]
        public string FrontLoad { get; set; }
    }
}
