using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EfTest.Models
{
    /// <summary>
    /// 行版本 帮助类
    /// </summary>
    public class RowVersionHelper
    {
        /*
         * <div class="form-group">          // 原始
         * <div class="form-group hidden">   // 修改后
         * 
         * 
         *  原始：  @Html.EditorFor(model => model.RowVersion, new { htmlAttributes = new { @class = "form-control" } })
         *  修改后：@Html.HiddenFor(model => model.RowVersion, new { htmlAttributes = new { @class = "form-control" } })
         */

        #region 行版本 接口
        /// <summary>
        /// 行版本 接口
        /// </summary>
        public interface IRowVersion
        {
            /// <summary>
            /// 行版本
            /// </summary>
            [Timestamp]
            [Display(Name = "行版本"),DisplayName("行版本")]
            byte[] RowVersion { get; set; }
        } 
        #endregion

        #region 修改数据时，如果行版本不一至，则报错，内容为：数据版本不一至，请返回重新进入再修改！
        private static readonly Exception _DbUpdateConcurrencyException = new Exception("数据版本不一至，请返回重新进入再修改！");
        /// <summary>
        /// 修改数据时，如果行版本不一至，则报错，内容为：数据版本不一至，请返回重新进入再修改！
        /// </summary>
        public static Exception DbUpdateConcurrencyException { get { return _DbUpdateConcurrencyException; } }

        private static readonly Exception _OptimisticConcurrencyException = new Exception("未设置行版本！");
        /// <summary>
        /// 未设置行版本！当更新操作违反并发约束时，就会引发此异常。
        /// </summary>
        public static Exception OptimisticConcurrencyException { get { return _OptimisticConcurrencyException; } }
        #endregion

        #region 设置行版本到上下文对应的实体上
        /// <summary>
        /// 设置行版本到上下文对应的实体上
        /// </summary>
        /// <param name="eFCodeFirstDbContext">数据上下文</param>
        internal static void SetRowVersion(System.Data.Entity.DbContext dbContext)
        {
            var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;
            foreach (System.Data.Entity.Core.Objects.ObjectStateEntry entry in objectContext.ObjectStateManager.GetObjectStateEntries(System.Data.Entity.EntityState.Modified))
            {
                var v = entry.Entity as RowVersionHelper.IRowVersion;
                if (v != null)
                {
                    v.RowVersion = RowVersionHelper.Get(HttpContext.Current.Request.Form);
                }
            }
            dbContext.ChangeTracker.DetectChanges();
        }

        /// <summary>
        /// 设置行版本到上下文对应的实体上
        /// </summary>
        /// <param name="eFCodeFirstDbContext">数据上下文</param>
        internal static async Task SetRowVersionAsync(EFCodeFirstDbContext eFCodeFirstDbContext)
        {
            await Task.Factory.StartNew(() => { SetRowVersion(eFCodeFirstDbContext); });
        }
        #endregion

        #region 从页面自动获取 行版本
        /// <summary>
        /// 从页面自动获取 行版本，字段名称为：RowVersion。
        /// 
        /// 示例：school.RowVersion = await RowVersionHelper.Get(Request.Form);
        /// 
        /// <![CDATA[
        /// 如果版本不一至，异常处理：
        /// catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
        /// {
        ///     return Content("数据版本不一至，请返回重新进入再修改！");
        /// }
        /// ]]>
        /// </summary>
        /// <param name="Form">将页面的 Request.Form 传入。</param>
        /// <returns>返回行版本的值</returns>
        public static async Task<byte[]> GetAsync(System.Collections.Specialized.NameValueCollection Form)
        {
            return await Task.Factory.StartNew(() =>
            {
                return Get(Form);
            });
        }

        /// <summary>
        /// 从页面自动获取 行版本，字段名称为：RowVersion。
        /// 
        /// 示例：school.RowVersion = await RowVersionHelper.Get(Request.Form);
        /// 
        /// <![CDATA[
        /// 如果版本不一至，异常处理：
        /// catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException ex)
        /// {
        ///     return Content("数据版本不一至，请返回重新进入再修改！");
        /// }
        /// ]]>
        /// </summary>
        /// <param name="Form">将页面的 Request.Form 传入。</param>
        /// <returns>返回行版本的值</returns>
        public static byte[] Get(System.Collections.Specialized.NameValueCollection Form)
        {
            try
            {
                byte[] byte1 = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    byte1[i] = Convert.ToByte(Form[$"RowVersion[{i}]"]);
                }
                return byte1;

            }
            catch(Exception)
            {
                return null;
            }
        } 
        #endregion


    }
}