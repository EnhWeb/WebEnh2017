namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kcsx_topic_fillavacantpositionansuser
    {
        public long Id { get; set; }

        public long? TaskId { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        public long? QueId { get; set; }

        [StringLength(4000)]
        public string Aswer { get; set; }
    }
}
