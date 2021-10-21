using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModel;
using Microsoft.AspNetCore.Html;

namespace BankOfSimba.Controllers
{
    [Route("show")]
    public class ShowController : Controller
    {
        [HttpGet("bankaccount")]
        public IActionResult BankAccount()          //název stejný jako ve View
        {
            BankAccount account =  new BankAccount("Simba", 2000, "lion");
            return View(account);
        }
        [HttpGet("listofaccounts")]
        public IActionResult ListOfAccounts()          //název stejný jako ve View
        {
            ListOfAnimals Animals = new ListOfAnimals();          //instance z ViewModel

            List<BankAccount> list = new List<BankAccount>
            {
                new BankAccount("Pupu", 500, "monkey"),
                new BankAccount("Dumbo", 650, "elephant"),
                new BankAccount("Brutus", 0, "lion"),
                new BankAccount("Zazo", 50, "bird")
            };
            Animals.listFromViewModel = list;           //property of Animals filled with list
            return View(Animals);
        }
        [HttpGet("showstring")]
        public IActionResult ShowString()          //název stejný jako ve View
        {
            return View("ShowString", "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>");
        }
    }
}
