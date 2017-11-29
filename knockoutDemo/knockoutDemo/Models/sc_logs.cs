namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_logs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(16)]
        public string ObjectType { get; set; }

        [StringLength(20)]
        public string OperaterType { get; set; }

        [StringLength(20)]
        public string OperateName { get; set; }

        public DateTime? OperaterTime { get; set; }

        [StringLength(96)]
        public string IpAddress { get; set; }

        [StringLength(1000)]
        public string UrlPath { get; set; }

        [StringLength(4000)]
        public string OperaterDescribe { get; set; }

        [Column(TypeName = "text")]
        public string ClientBrowserInfo { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
