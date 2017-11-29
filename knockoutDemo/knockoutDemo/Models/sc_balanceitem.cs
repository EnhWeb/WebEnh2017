namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_balanceitem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(100)]
        public string ItemFrom { get; set; }

        [StringLength(255)]
        public string ItemType { get; set; }

        public int? ParentId { get; set; }

        [StringLength(2)]
        public string Pistion { get; set; }

        [StringLength(2)]
        public string Method { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public int? Sort { get; set; }

        public bool IsAbs { get; set; }

        [StringLength(255)]
        public string Rule { get; set; }
    }
}
