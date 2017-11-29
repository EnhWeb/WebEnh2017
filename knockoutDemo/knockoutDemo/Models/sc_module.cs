namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_module
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string ModuleName { get; set; }

        [StringLength(36)]
        public string ModuleCode { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
