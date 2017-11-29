using EfTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Text;

namespace EfTest.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public async Task<StringBuilder> aab()
        {
            StringBuilder str = new StringBuilder();
            //using能及时释放资源,例如数据库连接异常，可以即使将上下文释放
            using (var db = new EFCodeFirstDbContext())
            {
                var guid = Guid.NewGuid();
                Student stu = new Student() { Id = guid, FullName = "cuiyanwei", Age = 25 };
                db.Students.Add(stu);
                await db.SaveChangesAsync();

                str.AppendLine(db.Students.Select(p => p.FullName).FirstOrDefault().ToString());
                

                Student stu1 = db.Students.Where(p => p.Id == guid).FirstOrDefault();
                stu1.FullName = "CYW";
                await db.SaveChangesAsync();

                str.AppendLine(db.Students.Select(p => p.FullName).FirstOrDefault().ToString());

            }

            return str;
        }
    }
}
