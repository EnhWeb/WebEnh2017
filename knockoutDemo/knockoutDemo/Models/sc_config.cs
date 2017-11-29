namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_config
    {
        public int? SortId { get; set; }

        [Key]
        [StringLength(50)]
        public string ConfigKey { get; set; }

        [StringLength(255)]
        public string ConfigName { get; set; }

        [Column(TypeName = "text")]
        public string ConfigValue { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [StringLength(255)]
        public string CreateUser { get; set; }

        [StringLength(255)]
        public string UpdateUser { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
