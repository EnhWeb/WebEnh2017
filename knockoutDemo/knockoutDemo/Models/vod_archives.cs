namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vod_archives
    {
        [StringLength(18)]
        public string Id { get; set; }

        [StringLength(18)]
        public string TypeId { get; set; }

        [StringLength(18)]
        public string CourseId { get; set; }

        public long? SortRank { get; set; }

        [StringLength(14)]
        public string Flag { get; set; }

        [StringLength(255)]
        public string ArcRank { get; set; }

        public int? Click { get; set; }

        public short? money { get; set; }

        [StringLength(255)]
        public string VodName { get; set; }

        [StringLength(60)]
        public string title { get; set; }

        [StringLength(36)]
        public string shorttitle { get; set; }

        [StringLength(20)]
        public string writer { get; set; }

        [StringLength(30)]
        public string source { get; set; }

        [StringLength(100)]
        public string litpic { get; set; }

        public decimal? VodSize { get; set; }

        public DateTime? pubdate { get; set; }

        [StringLength(30)]
        public string keywords { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? goodpost { get; set; }

        public int? badpost { get; set; }

        [StringLength(255)]
        public string filename { get; set; }

        [StringLength(36)]
        public string dutyadmin { get; set; }

        public short? VodDuration { get; set; }

        [StringLength(36)]
        public string CreateUserName { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(36)]
        public string LastEditorUserName { get; set; }

        public DateTime? LastEditorTime { get; set; }
    }
}
