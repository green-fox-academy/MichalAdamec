using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{
    public class ListOfTodos
    {
        public ToDo Todo { get; set; }

        public List<ToDo> AllToDos { get; set; }
    }
}
