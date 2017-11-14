using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using System.Data;
using Dapper;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // 轻量级ORM框架——第一篇：Dapper快速学习 - 一线码农 - 博客园
            // https://www.cnblogs.com/huangxincheng/p/5828470.html

//            轻量级ORM框架——第二篇：Dapper中的一些复杂操作和inner join应该注意的坑 -一线码农 - 博客园
//http://www.cnblogs.com/huangxincheng/p/5832281.html

//            C# MVC绑定 List<DapperRow>到bootstrap-table列表 - Zeroes - 博客园
//http://www.cnblogs.com/zeroes/p/dapperrow-list-serializer.html

            IDbConnection connection = new System.Data.SqlClient.SqlConnection("");
            IDbConnection connection1 = new MySql.Data.MySqlClient.MySqlConnection("");
            connection1.Execute("", new { });
            connection.Query<Object>("", new { });

            var query = connection.Query<object>("select * from Users where UserName=@UserName", new { UserName = "jack" });


            var result = connection.Execute("", new { });


            var sql = "select * from Product; select * from Users";
            var multiReader = connection.QueryMultiple(sql);
            var productList = multiReader.Read<Product>();
            var userList = multiReader.Read<Users>();
            multiReader.Dispose();


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
