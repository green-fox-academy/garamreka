using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    [Route ("/todo")]
    public class TodoController : Controller
    {
        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
