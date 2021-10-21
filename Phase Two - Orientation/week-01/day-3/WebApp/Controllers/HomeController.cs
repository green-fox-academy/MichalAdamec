using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [Route("home")]             //přidáno
    public class HomeController : Controller
    {
        [HttpGet("Pepa")]       //přidáno
        public IActionResult Index([FromQuery]string age)       
        {
            var model = new IndexViewModel() { Age = age, Title = "Main page" };
            return View(model);
        }
    }
}
