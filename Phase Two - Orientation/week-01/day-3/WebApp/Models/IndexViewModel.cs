

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class IndexViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
