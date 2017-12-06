using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostgreTest.Repositories;

namespace PostgreTest.Controllers
{
    public class HomeController : Controller
    {
        PGRepository PGRepository;

        public HomeController(PGRepository pGRepository)
        {
            this.PGRepository = pGRepository;
        }

        [Route ("api")]
        public IActionResult Index()
        {
            return Json(PGRepository.ListAll());
        }

        [Route("api/add")]
        public IActionResult Add()
        {
            PGRepository.Add();
            return RedirectToAction("Index");
        }
    }
}
