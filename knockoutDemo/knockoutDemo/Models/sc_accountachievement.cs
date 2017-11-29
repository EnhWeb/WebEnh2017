namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_accountachievement
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserId { get; set; }

        [StringLength(36)]
        public string SchoolId { get; set; }

        [StringLength(36)]
        public string DepartmentId { get; set; }

        [StringLength(50)]
        public string StudentID { get; set; }

        [StringLength(100)]
        public string ClassName { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string IndustryName { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string PeriodName { get; set; }

        public decimal? Score { get; set; }

        [StringLength(50)]
        public string AchievementType { get; set; }

        public DateTime? DoQuestionDurationTime { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(36)]
        public string CaseId { get; set; }
    }
}
