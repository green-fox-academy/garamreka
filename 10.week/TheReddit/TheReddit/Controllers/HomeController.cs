using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheReddit.Repositories;
using TheReddit.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheReddit.Controllers
{
    public class HomeController : Controller
    {
        RedditPostRepository RedditPostRepository;

        public HomeController(RedditPostRepository redditPostRepository)
        {
            this.RedditPostRepository = redditPostRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("read")]
        public IActionResult Read()
        {
            return View(RedditPostRepository.GetPost());
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddPost(RedditPost post)
        {
            RedditPostRepository.AddPost(post);
            return RedirectToAction("Read");
        }

        [HttpGet]
        [Route("/{id}/upvote")]
        public IActionResult Upvote([FromQuery] long id)
        {
            RedditPostRepository.UpvotePost(RedditPostRepository.GetID(id));
            return RedirectToAction("Read");
        }

        [HttpGet]
        [Route("/{id}/downvote")]
        public IActionResult Downvote([FromQuery] long id)
        {
            RedditPostRepository.DownvotePost(RedditPostRepository.GetID(id));
            return RedirectToAction("Read");
        }

    }
}
