using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfTest.Models
{
    public class School : RowVersionHelper.IRowVersion
    {
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [Display(Name = "学校名称")]
        [Required]
        [MinLength(2, ErrorMessage = "学校名称最小长度2字符。"), MaxLength(30, ErrorMessage = "最大长度30字符。")]
        public string Name { get; set; }


        /// <summary>
        /// 行版本
        /// </summary>
        [Timestamp]
        [Display(Name = "行版本")]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [ConcurrencyCheck()]
        public DateTime CreateTime { get; set; }

    }
}