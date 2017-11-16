using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuthorApp.Repositories;
using AuthorApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthorApp.Controllers
{

    public class HomeController : Controller
    {
        AuthorRepository AuthorRepository;

        public HomeController(AuthorRepository authorRepository)
        {
            this.AuthorRepository = authorRepository;
        }

        [HttpGet]
        [Route ("/author")]
        public IEnumerable<Author> GetAll()
        {
            return AuthorRepository.GetAllAuthor();
        }

        [HttpGet]
        [Route("/author/{id}")]
        public IActionResult GetById([FromRoute] long id)
        {
            var author = AuthorRepository.GetAuthorById(id);

            if (author == null)
            {
                return NotFound();
            }
            else
            {
                //return new ObjectResult(author);
                return Json(author);
            }
        }

        [HttpPost]
        [Route("/add")]
        public IActionResult AddAuthor([FromBody] Author author)
        {
            if (author == null)
            {
                return BadRequest();
            }
            else
            {
                AuthorRepository.AddAuthor(author);
                //return Ok(author);
                return Json(author);
            }
        }

        [HttpDelete]
        [Route("/remove/{id}")]
        public IActionResult RemoveAuthor([FromRoute] long id)
        {
            var author = AuthorRepository.GetAuthorById(id);

            if (author == null)
            {
                return BadRequest();
            }
            else
            {
                AuthorRepository.RemoveAuthor(author);
                return new NoContentResult();
            }
        }

        [HttpPut]
        [Route("/update/{id}")]
        public IActionResult UpdateAuthor([FromRoute] long id, [FromBody] Author author)
        {
            if (author == null)
            {
                return BadRequest();
            }
            else
            {
                AuthorRepository.UpdateAuthor(author, id);
                return Json(author);
            }
        }
    }
}
