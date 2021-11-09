using Frontend.Models;
using Frontend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public LogService LogService { get; set; }
        public HomeController(LogService logService)
        {
            LogService = logService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery] int? input)
        {
            if (input is null)
            {
                return Ok(new { error = "Please provide an input!" });
            }
            LogService.Add(new Log() { CreatedAt = DateTime.Now, Endpoint = "doubling", Data =input.ToString()});
            return Ok(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery] string name, string title)
        {
            if (name == null && title == null)
            {
                var error = new { error = "Please provide a name and a title!" };       //anonymní objekt, status code 1.způsob
                return StatusCode(400, error);
            }
            else if (title == null)
            {
                return BadRequest(new { error = "Please provide a title!" });           //anonymní objekt, status code 2.způsob
            }
            else if (name == null)
            {
                return BadRequest(new { error = "Please provide a name!" });                       //anonymní objekt
            }
            else
            {
                LogService.Add(new Log() { CreatedAt = DateTime.Now, Endpoint = "greet", Data = name + " " + title });

                return Ok(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA([FromRoute] string appendable)
        {
            if (appendable == null)
                return NotFound(new { text = "Not found" });

            LogService.Add(new Log() { CreatedAt = DateTime.Now, Endpoint = "appenda", Data = appendable });

            return Ok(new { appended = appendable += 'a' });
        }

        [HttpPost("dountil/{operation}")]
        public IActionResult DoUntil([FromRoute] string operation, [FromBody] UntilRequest until)
        {
            if (until == null)
                return Ok(new { error = "Please provide a number!" });

            LogService.Add(new Log() { CreatedAt = DateTime.Now, Endpoint = "dountil", Data = until.Until.ToString() });

            switch (operation)
            {
                case "sum":
                    return Ok(new { result = until.Add() });

                case "factor":
                    return Ok(new { result = until.Factor() });

                default:
                    return null;
            }
        }

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody] ArraY array)
        {
            if (array.What == "" || array.Numbers == null)
            { return Ok(new { error = "Please provide what to do with the numbers!" }); }

            LogService.Add(new Log() { CreatedAt = DateTime.Now, Endpoint = "array", Data = array.ToString() });

            switch (array.What)
            {
                case "sum":
                    return Ok(new { result = array.Sum() });

                case "multiply":
                    return Ok(new { result = array.Multiply() });

                case "double":
                    return Ok(new { result = array.Double() });

                default:
                    return null;
            }

        }

        [HttpGet("log")]
        public IActionResult Log()
        {
            LogList list = new LogList();
            var logs = LogService.FindAll();
            list.LogsCount = logs.Count();
            list.ListOfLogs = logs;

            return Ok(new { list});
        }

        //[HttpPost("sith")]
        //public IActionResult Sith([FromBody] ReverserOfSith reverser)
        //{
        //    if (reverser == null || reverser.Text == string.Empty)
        //        return Ok(new { error = "Feed me some text you have to, padawan young you are. Hmmm." });
        //    reverser.Reverse();
        //    return null;
        //}

        [HttpPost("translate")]
        public IActionResult Translate([FromBody] Translator translator)
        {
            Translator tr = new Translator();
            tr.Text = translator.Translate();
            tr.Lang = "teve";
            return Ok(tr);
        }
    }
}
