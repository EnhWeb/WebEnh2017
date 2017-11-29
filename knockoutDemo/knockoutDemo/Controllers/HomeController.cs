using knockoutDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace knockoutDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Basic()
        {
            return View();
        }

        public async Task<ActionResult> Advanced()
        {
            Model1 db1 = new Model1();
            db1.sc_user.Add(new sc_user
            {
                Id = "abc",
                Name = "aaa",
                UserName = "张三",
                ActivationNo = "sdf",
                MobileNumber = "sss",
                EmailAddress = "fff",
                SchoolId = "fffffsssss",
                UserRoleId = "eeeeeeee",
                StudentID = "ddddd",
                ClassName = "333333",
                LoginNum = 5,
                LastLoginBrowser = "google",
                LastLoginIp = "ffewerwer",
                LastEdit = "webenh",
                ActivationDate = DateTime.Now,
                ExpireDate = DateTime.Now.AddDays(55),
                LastLoginDate = DateTime.Now.AddDays(66),
                LastUpdateDate1 = DateTime.Now.AddDays(77),
                TieNo = 5555,
                ClassNo = 6666
            });

            //db1.Database.SqlQuery ( sc_user, "", new { });

            var updateCount = db1.SaveChanges();//await db1.SaveChangesAsync();



            System.Web.HttpContext.Current.Response.Write($"updateCount:{updateCount}.");
            return View();
        }
    }
}
