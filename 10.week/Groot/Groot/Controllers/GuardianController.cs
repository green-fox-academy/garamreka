using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Groot.Models;
using Groot.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        GuardianService GuardianService;

        public GuardianController(GuardianService guardianService)
        {
            this.GuardianService = guardianService;
        }

        [HttpGet]
        [Route ("/groot")]
        public IActionResult Groot(string message)
        {
            return GuardianService.CheckIfNull(message);   
        }
    }
}
