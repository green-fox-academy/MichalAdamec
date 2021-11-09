using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldRESTApp.Models;

namespace HelloWorldRESTApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        static int webCalls = 0;
        [HttpGet("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            webCalls++;
            Greeting greet = new Greeting(name);
            greet.ID = webCalls;
            return View("Greeting",greet);
        }
    }
}
