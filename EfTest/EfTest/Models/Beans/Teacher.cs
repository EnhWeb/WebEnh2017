using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfTest.Models
{

    /// <summary>
    /// 老师表
    /// </summary>
    [DisplayName("老师")]
    public class Teacher : RowVersionHelper.IRowVersion
    {

        [DisplayName("老师ID")]
        public Guid Id { get; set; }

        [MinLength(2, ErrorMessage = "学校名称最小长度2字符。"), MaxLength(30, ErrorMessage = "最大长度30字符。")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 行版本
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}