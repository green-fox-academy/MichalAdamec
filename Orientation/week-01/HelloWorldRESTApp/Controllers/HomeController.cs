using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldRESTApp.Controllers
{
    public class HomeController : Controller            //make sure it extends the Controller class
    {
        [Route("")]
        public string Index()
        {
            return "Hello from Controller!";
        }
    }
}
