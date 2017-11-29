namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_user
    {
        [StringLength(360)]
        public string Id { get; set; }

        [StringLength(36)]
        public string UserName { get; set; }

        [StringLength(36)]
        public string NickName { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(255)]
        public string ActivationNo { get; set; }

        [StringLength(11)]
        public string MobileNumber { get; set; }

        [StringLength(40)]
        public string EmailAddress { get; set; }

        [StringLength(18)]
        public string SchoolId { get; set; }

        [StringLength(2)]
        public string UserRoleId { get; set; }

        [StringLength(36)]
        public string UserTypeId { get; set; }

        public int? UserState { get; set; }

        [StringLength(20)]
        public string StudentID { get; set; }

        [StringLength(100)]
        public string ClassName { get; set; }

        public int? LoginNum { get; set; }

        [StringLength(255)]
        public string LastLoginBrowser { get; set; }

        [StringLength(96)]
        public string LastLoginIp { get; set; }

        [StringLength(36)]
        public string LastEdit { get; set; }

        public DateTime? RegisterDate { get; set; }

        public DateTime? ActivationDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public DateTime? LastUpdateDate1 { get; set; }

        public int? TieNo { get; set; }

        public int? ClassNo { get; set; }
    }
}
