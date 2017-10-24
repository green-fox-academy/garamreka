using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstWebApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int LoadCounter = 0;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting(name)
            {
                Id = 1,
                Content = name
            };

            LoadCounter++;
            return View(greeting);
        }
    }
}
