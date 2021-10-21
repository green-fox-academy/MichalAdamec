using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldRESTApp.Models;

namespace HelloWorldRESTApp.Controllers
{
    [Route("api")]              //= endpoint: /api
    public class RestController : Controller
    {
        static int apiCalls = 0;
        public IActionResult Index([FromQuery]string name)          //zde se odkazuje na html document uložený ve Views(pokud je vytvořený)
        {                                                           //FromQuery = dotaz v rámci URL kde /api/greeting?name=Michal
            return View();
        }
        [HttpGet("greeting")]           //= endpoint: /api/greeting
        public Greeting Greet(string name)
        {
            apiCalls += 1;
            Greeting greet = new Greeting();
            greet.Content = $"Hello {name}, you are awesome!";
            greet.ID = apiCalls;
            return greet;
        }
    }
}
