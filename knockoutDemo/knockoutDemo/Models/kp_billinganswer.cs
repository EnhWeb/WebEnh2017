namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kp_billinganswer
    {
        public int Id { get; set; }

        public int? QuestionID { get; set; }

        [StringLength(36)]
        public string UserID { get; set; }

        [StringLength(1000)]
        public string Answer { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
