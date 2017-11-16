using Arrow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arrow.Services
{
    public class ArrowService : Controller
    {
        public IActionResult CheckIfNull(double? distance, double? time)
        {
            if (distance == null || time == null)
            {
                return new NotFoundObjectResult(new ErrorMessage());
            }
            else
            {
                return Json(new Response() { Distance = distance, Time = time, Speed = distance / time });
            }
        }
    }
}
