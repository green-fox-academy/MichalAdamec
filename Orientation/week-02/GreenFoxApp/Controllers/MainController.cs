using GreenFoxApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxApp.Controllers
{
    [Route("")]
    public class MainController : Controller
    {
        public StudentService Service { get; set; }         //property MainControlleru, zde se uloží Student service poslaný StartUpem
        public MainController(StudentService service)       //Constructor MainControleru, typ StudentService si bere ze Startupu
        {
            Service = service;
        }
        [Route("gfa")]
        public IActionResult MainPage()         //contains links to other pages
        {
            return View();
        }
        [Route("gfa/list")]
        public IActionResult ListOfStudents()       //link to list of students
        {

            return View();
        }
    }
}
