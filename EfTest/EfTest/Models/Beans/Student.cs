using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EfTest.Models
{
    public class Student
    {
        //定义无参数的构造函数主要是因为在通过DbSet获取对象进行linq查询时会报错
        //The class 'EFCodeFirstModels.Student' has no parameterless constructor.
        public Student() { }

        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// 姓名，全名
        /// </summary>
        [DisplayName("姓名")]
        [Display(Name = "姓名", Description = "用户姓名")]
        [Required(ErrorMessage = "姓名不能为空！")]
        [MinLength(4, ErrorMessage = "最少4个字。"), MaxLength(25, ErrorMessage = "最大字符为25。")]
        [StringLength(25, ErrorMessage = "错误，最大字符长度为25字节。")]
        [ConcurrencyCheck()]
        public string FullName { get; set; }

        [Display(Name = "年龄", GroupName = "年龄组名", Description = "年龄描术", ShortName = "网格列年龄名称")]
        //[StringLength(3,MinimumLength =2,ErrorMessage ="请输入正确的年龄")]
        public int Age { get; set; }

        [Phone(ErrorMessage = "请输入正确的手机号码！")]
        public string Phone { get; set; }

        [MinLength(5, ErrorMessage = "QQ号最少5位。"), MaxLength(13, ErrorMessage = "QQ号最长13位。"), RegularExpression("[1-9][0-9]{4,12}", ErrorMessage = "请输入正确的QQ号码。")]
        public string QQ { get; set; }


        [MinLength(6, ErrorMessage = "请输入正确的邮箱地址。"), MaxLength(30, ErrorMessage = "您的邮箱账号长度过长，请更换其它邮箱账号。")]
        [EmailAddress(ErrorMessage = "请输入正确的邮箱地址！")]
        public string Email { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        [Display(Name = "创建时间")]
        [ConcurrencyCheck()]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 数据行版本号
        /// </summary>
        [Display(Name = "数据行版本号")]
        [Timestamp]
        public byte[] RowVersion { get; set; }






        public virtual Guid SchoolId { get; set; }
        public virtual School School { get; set; }

    }
}