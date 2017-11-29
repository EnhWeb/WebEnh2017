namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vod_arctype
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(18)]
        public string ReId { get; set; }

        [StringLength(18)]
        public string TopId { get; set; }

        public short? SortRank { get; set; }

        public int? Click { get; set; }

        [StringLength(30)]
        public string TypeName { get; set; }

        [StringLength(100)]
        public string TypeDir { get; set; }

        public float? PageSize { get; set; }

        public short? Corank { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        [StringLength(60)]
        public string KeyWords { get; set; }

        [StringLength(80)]
        public string SeoTitle { get; set; }

        public bool? IsHidden { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        [StringLength(255)]
        public string CreateUserName { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastEditorTime { get; set; }

        public DateTime? LastEditorUserName { get; set; }
    }
}
