using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Groot.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route ("/groot")]
        public IActionResult Groot(string message)
        {
            if (message == null)
            {
                return Json(new ErrorMessage());
            }
            else
            {
                return Json(new Translation() { Received = message });
            }
            
        }
    }
}
