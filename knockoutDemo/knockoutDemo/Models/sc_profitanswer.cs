namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_profitanswer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(36)]
        public string UserID { get; set; }

        [Required]
        [StringLength(36)]
        public string CaseId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AnswerContent { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime EditTime { get; set; }

        public int HasCorrect { get; set; }
    }
}
