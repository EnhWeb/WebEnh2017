using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWord.Controllers
{
    public class DictionaryDemoController : Controller
    {
        // GET: DictionaryDemo
        public ActionResult Index()
        {
            //定义
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // 添加元素
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            string result = string.Format("For key = \"rtf\", value = {0}.", openWith["rtf"]);


            //更改值
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);


            return Content(result);

            return View();
        }


    }
}