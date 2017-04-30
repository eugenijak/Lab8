using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Cообщение";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Time()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}
