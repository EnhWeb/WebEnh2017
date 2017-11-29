namespace knockoutDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sc_app_getui_pushmessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(36)]
        public string ClientId { get; set; }

        public byte? TransmissionType { get; set; }

        [StringLength(255)]
        public string TransmissionContent { get; set; }

        public bool? IsOfflinePush { get; set; }

        public long? OfflineExpireTimeMillisecond { get; set; }

        public DateTime? OfflineExpireTime { get; set; }

        public DateTime? OfflineBeginTime { get; set; }

        public DateTime? OfflineEndTime { get; set; }

        public DateTime? ToShowBeginTime { get; set; }

        public DateTime? ToShowEndTime { get; set; }

        [StringLength(22)]
        public string AppIdList { get; set; }

        public byte? PushNetWorkType { get; set; }

        public int? Speed { get; set; }

        [StringLength(11)]
        public string PhoneTypeList { get; set; }

        [StringLength(1000)]
        public string ProvinceList { get; set; }

        [StringLength(255)]
        public string TagList { get; set; }

        [StringLength(36)]
        public string TaskContentId { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }
    }
}
