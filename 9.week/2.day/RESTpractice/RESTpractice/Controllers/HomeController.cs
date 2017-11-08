using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTpractice.Models;

namespace RESTpractice.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route ("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet]
        [Route("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        [Route("/appenda")]
        public IActionResult Appenda(string appendable)
        {
            if (string.IsNullOrEmpty(appendable))
            {
                return NotFound();
            }
            else
            {
                return Json(new { appended = $"{appendable}a" });
            }
        }

        [HttpPost]
        [Route("/dountil/{what}")]
        [Route("/dountil")]
        public IActionResult Dountil(string what, [FromBody] Properties until)
        {
            int resultNumber = 0;
            if (until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (string.IsNullOrEmpty(what))
            {
                return NotFound();
            }
            else if (what == "sum")
            {
                for (int i = 0; i <= until.Until; i++)
                {
                    resultNumber += i;
                }
            }
            else if (what == "factor")
            {
                resultNumber = 1;
                for (int i = 1; i <= until.Until; i++)
                {
                    resultNumber *= i;
                }
            }
            return Json(new { result = $"{resultNumber}" });
        }

        [HttpPost]
        [Route("/arrays")]
        public IActionResult ArrayHandler([FromBody] Properties properties)
        {
            if (string.IsNullOrEmpty(properties.What))
            {
                return NotFound();
            }
            else if (properties.What == "double")
            {
                int[] resultArray = new int[properties.Numbers.Length];
                for (int i = 0; i < properties.Numbers.Length; i++)
                {
                    resultArray[i] = properties.Numbers[i] * 2;
                }
                return Json(new { result = resultArray });
            }
            else if (properties.What == "sum")
            {
                int resultNumber = 0;
                for (int i = 0; i < properties.Numbers.Length; i++)
                {
                    resultNumber += properties.Numbers[i];
                }
                return Json(new { result = $"{resultNumber}" });
            }
            else if (properties.What == "multiply")
            {
                int resultNumber = 1;
                for (int i = 0; i < properties.Numbers.Length; i++)
                {
                    resultNumber *= properties.Numbers[i];
                }
                return Json(new { result = $"{resultNumber}" });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }

        [HttpGet]
        [Route("/log")]
        public IActionResult Log()
        {
           return Json(new {  });
        }
    }
}
