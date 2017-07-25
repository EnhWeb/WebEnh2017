using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShortUrl.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {

            return Content($"id:{id}", "text/html", System.Text.Encoding.UTF8);

            //return Redirect($"http://{id}");

            //return View();
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
            return View();
        }
    }
}
