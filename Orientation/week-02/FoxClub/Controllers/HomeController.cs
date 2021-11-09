using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public FoxServices FoxServices { get; set; }
        public HomeController(FoxServices foxServices)
        {
            FoxServices = foxServices;
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)         //name z View Login
        {
            Fox fox = new Fox(name);
            FoxServices.Foxes.Add(fox);

            return RedirectToAction("Information", new { Name = name });
            //redirect to index page -> actionName = page to redirect, new {Name = name} (property Foxu = Login parameter)
        }

        [HttpGet("home")]
        public IActionResult Home()         //funkční
        {
            return View();
        }

        [HttpGet("information")]
        public IActionResult Information(string name)
        {
            Fox fox = FoxServices.GetFox(name);
            return View(fox);       //posílám objekt
        }

        [HttpGet("nutrition")]
        public IActionResult NutritionStore([FromQuery]string name)
        {
            Fox fox = FoxServices.GetFox(name);
            return View(fox);
        }

        [HttpPost("nutrition")]
        public IActionResult NutritionStore(string food, string drink)
        {

            return RedirectToAction("Information", new { Food = "food", Drink = "drink" });
        }

        [HttpGet("tricks")]
        public IActionResult TrickCenter()
        {
            return View(FoxServices);
        }

        //[HttpPost("tricks")]
        //public IActionResult TrickCenter()
        //{
        //    return View();
        //}

        [HttpGet("history")]
        public IActionResult ActionHistory()
        {
            return View(FoxServices);
        }
    }
}
