﻿using System;
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
        public IActionResult Dountil(string what, [FromBody] DoUntil until)
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

            if (what == "sum")
            {
                for (int i = 0; i <= until.Until; i++)
                {
                    resultNumber += i;
                }
            }

            if (what == "factor")
            {
                resultNumber = 1;
                for (int i = 1; i <= until.Until; i++)
                {
                    resultNumber *= i;
                }
            }

            return Json(new { result = $"{resultNumber}" });
        }
    }
}