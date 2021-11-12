using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlAliaser.Services;
using UrlAliaser.Views.ViewModel;

namespace UrlAliaser.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public DbService DbService { get; set; }

        public HomeController(DbService dbService)
        {
            DbService = dbService;
        }

        [HttpGet("")]
        public IActionResult Main()
        {
            return View();
        }

        [HttpPost("save-link")]
        public IActionResult Save(string alias, string url)
        {
            string text;

            if ((url == null || alias == null) || (url == null && alias == null))
            {
                text = "You need to fill both url & alias!";
                return View("Main", text);
            }
            else
            {
                text = DbService.Add(url, alias);

                return View("Main", text);
            }
        }

        [HttpGet("~/a/{alias}")]
        public IActionResult GetPage([FromRoute] string alias)
        {
            string url = "";
            var form = DbService.FindByAlias(alias);
            if (form != null)
            {
                form.HitCount++;
                DbService.DbContext.SaveChanges();
                url = form.Url;
                return Redirect(url);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
