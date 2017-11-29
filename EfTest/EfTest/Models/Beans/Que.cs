using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfTest.Models
{
    /// <summary>
    /// 题目表
    /// </summary>
    [DisplayName("题目表")]

    public class Que : RowVersionHelper.IRowVersion
    {
        /// <summary>
        /// 题目ID
        /// </summary>
        [Display(Name = "主键")]
        public Guid Id { get; set; }

        /// <summary>
        /// 题目标题
        /// </summary>
        [Display(Name = "题目标题")]
        [StringLength(35)]
        [ConcurrencyCheck()]// 检查修改时不能修改这个项
        public string TopicTitle { get; set; }

        /// <summary>
        /// 题干
        /// </summary>
        [Display(Name = "题干")]
        [StringLength(2000)]
        public string Stem { get; set; }

        /// <summary>
        /// 题目图片
        /// </summary>
        [Display(Name = "题目图片")]
        [StringLength(2000)]
        [DataType(DataType.Html)]
        public string TopicPic { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [ConcurrencyCheck()]
        public DateTime CreateTime { get; set; }

        [Display(Name = "修改时间"), DisplayName("上次编辑时间"), DisplayFormat(ConvertEmptyStringToNull = false, DataFormatString = "yyyy-MM-dd HH:ss:mm", NullDisplayText = "未修改")]
        [DataType(DataType.DateTime)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 行版本号
        /// </summary>
        [Display(Name = "行版本号")]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}