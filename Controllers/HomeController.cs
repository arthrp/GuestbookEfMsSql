using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GuestbookEfMsSql.Models;
using GuestbookEfMsSql.Repositories;
using GuestbookEfMsSql.Dtos;

namespace GuestbookEfMsSql.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostRepository _postRepository;

        public HomeController(ILogger<HomeController> logger, PostRepository postRepository)
        {
            _logger = logger;
            _postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var data = _postRepository.GetAll();
            var model = new GuestbookViewModel(){ AllPosts = data };
            return View(model);
        }

        public IActionResult AddPost(PostDto post)
        {
            post.AddedDate = DateTime.UtcNow;
            _postRepository.Insert(post);

            var posts = _postRepository.GetAll();
            var model = new GuestbookViewModel() { AllPosts = posts };
            return View("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
