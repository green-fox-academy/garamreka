using Groot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Groot.Services 
{
    public class GuardianService : Controller
    {
        internal IActionResult CheckIfNull(string message)
        {
            if (message == null)
            {
                return new NotFoundObjectResult(new ErrorMessage());
            }
            else
            {
                return Json (new Translation() { Received = message });
            }
        }
    }
}
