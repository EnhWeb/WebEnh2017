namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_adminuser
    {
        [StringLength(36)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserName { get; set; }

        [StringLength(60)]
        public string NickName { get; set; }

        [StringLength(200)]
        public string Pwd { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(500)]
        public string Roles { get; set; }

        public int? States { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? LastDate { get; set; }
    }
}
