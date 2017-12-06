using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DbRelationMockPractice.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DbRelationMockPractice.Controllers
{
    public class HomeController : Controller
    {
        PracticeRepository PracticeRepository;
        IPracticeRepository IPracticeRepository;

        public HomeController(PracticeRepository practiceRepository, IPracticeRepository ipracticeRepository)
        {
            this.PracticeRepository = practiceRepository;
            this.IPracticeRepository = ipracticeRepository;
        }

        [Route ("/api/info")]
        public IActionResult Info()
        {
            return Json(PracticeRepository.GetEverything());
        }
    }
}
