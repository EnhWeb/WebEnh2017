namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_orderlog
    {
        public int Id { get; set; }

        [StringLength(40)]
        public string OrderNo { get; set; }

        [Required]
        [StringLength(8000)]
        public string RequestData { get; set; }

        [StringLength(8000)]
        public string ResponseData { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
