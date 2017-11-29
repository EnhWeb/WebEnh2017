namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_cashieruseranswer
    {
        [Key]
        public int UANo { get; set; }

        public int PaperNo { get; set; }

        public int TopicNo { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string SortNo { get; set; }

        [StringLength(100)]
        public string AnswerContent { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? EditTime { get; set; }

        public int HasCorrect { get; set; }

        [StringLength(50)]
        public string TableName { get; set; }
    }
}
