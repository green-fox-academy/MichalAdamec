using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebApp.Models;

namespace BasicWebApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public static List<Item> listFull = new List<Item>();

        [HttpGet("")]
        public IActionResult Home()         //název stejný jako View
        {
            List<Item> listOfItems = new List<Item>()
            {
                new Item("Harness for skinnies", "children and anorectics size", 200, 10),
                new Item("Chalk", "baby powder and hand dryer in one", 30, 5),
                new Item("Pies de Gato", "fancy climbing shoes", 150, 25),
                new Item("Rope", "not suitable for climbing - perfect for hanging laundry", 30, 5),
                new Item("Hammock", "Do you wanna hang out?", 160,8),
                new Item("Diamond climbing shoes", "every rich-bitch must-have, but not very comfortable", 1000, 1),
                new Item("Carabine", "My preciouss sshiny!", 50, 20),
                new Item("Cord", "for climbers with suicidal tendencies", 15, 13)
            };

            listFull = listOfItems;                //ukládám list pro pozdější použití - instatnce listu vytvořena v HomeController : Controller

            ListOfItems listObj = new ListOfItems();
            listObj.ListFromModel = listOfItems;
            return View(listObj);
        }
        [HttpGet("cheapest")]
        public IActionResult Cheapest()
        {
            Item cheapestItem = new Item();
            int price = 10000;
            foreach (var item in listFull)
            {
                if (item.Price < price)
                {
                    price = item.Price;
                    cheapestItem = item;
                }
            }
            ListOfItems listObj = new ListOfItems();
            listObj.Add(cheapestItem);
            return View("home",listObj);
        }
    }
}
