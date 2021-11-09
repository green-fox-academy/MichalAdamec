using Microsoft.AspNetCore.Mvc;
using Reddit.Models;
using Reddit.Models.ViewModels;
using Reddit.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Controllors
{

    [Route("")]
    public class HomeController : Controller
    {
        public PostService Service { get; set; }
        public HomeController(PostService service)          //přijímá transient service ze Startupu a posílá ho do property
        {
            Service = service;
        }

        [HttpGet("")]
        public IActionResult PostPage()
        {
            PostList listOfPosts = new PostList();
            List<Post> list = Service.ListAll();

            listOfPosts.ListOfPosts = list;
            
            return View(listOfPosts);
        }

        [HttpGet("vote")]
        public IActionResult Vote([FromQuery] int vote, long id)
        {
            Service.Vote(vote, id);
            return RedirectToAction("PostPage");
        }

        [HttpGet("submit")]
        public IActionResult SubmitPage()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(string url, string title)
        {
            Service.Add(new Post() {Title = title, Url = url, DateTime = DateTime.Now});
            return RedirectToAction("PostPage");
        }
    }
}
