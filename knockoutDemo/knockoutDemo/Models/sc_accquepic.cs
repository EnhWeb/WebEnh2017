namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accquepic
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string QueId { get; set; }

        [StringLength(100)]
        public string Url { get; set; }

        public int? SeqNo { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        public float? FileSize { get; set; }
    }
}
