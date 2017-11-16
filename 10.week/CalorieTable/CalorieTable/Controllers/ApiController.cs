using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalorieTable.Models;
using CalorieTable.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieTable.Controllers
{
    [Route ("/api")]
    public class ApiController : Controller
    {
        FoodRepository FoodRepository;

        public ApiController(FoodRepository foodRepository)
        {
            this.FoodRepository = foodRepository;
        }

        [HttpGet]
        [Route ("/api/table")]
        public IEnumerable<Food> GetAll()
        {
            return FoodRepository.GetAllFood();
        }

        [HttpGet]
        [Route("/api/table/{id}")]
        public IActionResult GetById([FromRoute] long id)
        {
            var food = FoodRepository.GetID(id);
            return Json(food);
        }

        [HttpPost]
        [Route ("/api/add")]
        public IActionResult AddFood([FromBody] Food food)
        {
            FoodRepository.AddFood(food);
            return Json(food);
        }

        [HttpDelete]
        [Route ("api/remove/{id}")]
        public IActionResult RemoveFood([FromRoute] long id)
        {
            var food = FoodRepository.GetID(id);

            if (food == null)
            {
                return BadRequest();
            }
            else
            {
                FoodRepository.Remove(food);
                return new NoContentResult();
            }
        }

        [HttpPut]
        [Route ("/api/update/{id}")]
        public IActionResult Update([FromRoute] long id, [FromBody] Food food)
        {
            FoodRepository.UpdateAmount(food, id);
            return Json(food);
        }
    }
}
