using BankOfSimba2.Models;
using BankOfSimba2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba2.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [Route("show")]
        public IActionResult Show()
        {
            BankAccount simba = new BankAccount("Simba", 2000, "lion");
            return View(simba);
        }

        [Route("animals")]
        public IActionResult Animals()
        {
            Animals animals = new Animals();
            List<BankAccount> list = new List<BankAccount>()
            {
                new BankAccount( "Gif", 200, "monkey" ),
                new BankAccount("Dadie", 5000, "lion"),
                new BankAccount("Paco", 150, "fox"),
                new BankAccount("Moko", 50, "bird")
            };
            animals.AnimalsList = list;

            return View(animals);
        }
    }
}
