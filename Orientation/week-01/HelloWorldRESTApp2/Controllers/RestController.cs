using HelloWorldRESTApp2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldRESTApp2.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        static int idCalls = 0;
        [HttpGet]
        [Route("greeting")]
        public Greeting Greet([FromQuery] string name)
        {
            idCalls++;
            Greeting greet = new Greeting();
            greet.Content = $"Hello {name}!";
            greet.Id = idCalls;

            return greet;
        }
    }
}
