namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_app_message_getui
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(36)]
        public string GetuiID { get; set; }

        [StringLength(255)]
        public string Message { get; set; }

        [StringLength(2000)]
        public string Body { get; set; }

        [StringLength(255)]
        public string Image01 { get; set; }

        [StringLength(255)]
        public string Image02 { get; set; }

        public DateTime? SendTime { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }
    }
}
