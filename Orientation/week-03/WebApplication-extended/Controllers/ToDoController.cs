using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.ViewModels;
using WebApplication1.Servises;

namespace WebApplication1.Controllers
{
    [Route("todo")]
    public class ToDoController : Controller
    {
        private ToDoService ToDoService { get; }
        public ToDoController(ToDoService service)
        {
            ToDoService = service;
        }


        [HttpGet("")]           //shows a table
        [HttpGet("list")]
        public IActionResult List()
        {
            var viewModel = new ListOfTodos() { AllToDos = ToDoService.FindAll() };
            return View(viewModel);
        }


        [HttpPost("list")]
        public IActionResult List(string todo)      //todo název jako name="todo" ve formulari
        {
            ToDoService.Add(todo);

            return RedirectToAction("List");
        }


        [HttpGet("add")]
        public IActionResult Add()
        {
            return View("AddTask");
        }


        [HttpGet("{id:long}/delete")]
        public IActionResult Delete([FromRoute]long id)
        {
            ToDoService.Delete(id);
            return RedirectToAction("List");
        }


        [HttpGet("{id:long}/update")]
        public IActionResult Update([FromRoute]long id)
        {
            ToDo obj = ToDoService.FindById(id);
            return View("UpdateTask", obj);
        }


        [HttpPost("{id:long}/update")]
        public IActionResult Update(ToDo todo)
        {
            ToDoService.Update(todo);
            return RedirectToAction("List");
        }


        [HttpGet("unfinished")]
        public IActionResult Unfinished()
        {
            ListOfTodos unfinished = new ListOfTodos();
            List<ToDo> list = ToDoService.FindAll().Where(c => c.IsDone == false).ToList();

            unfinished.AllToDos = list;

            return View(unfinished);
        }

        [HttpGet("search")]
        public IActionResult Search()
        {
            return View();
        }

    }
}
