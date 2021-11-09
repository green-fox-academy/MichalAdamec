using HelloWorldRESTApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldRESTApp2.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static int countCalls = 0;
        [HttpGet("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            countCalls++;
            var greeting = new Greeting();
            greeting.Id = countCalls;
            greeting.Content = name;

            return View(greeting);
        }
    }
}
