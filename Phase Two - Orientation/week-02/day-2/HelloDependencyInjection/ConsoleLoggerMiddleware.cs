using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDependencyInjection
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        public Printer Printer { get; set; }
        public  IColor Color { get; set; }
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Color.PrintColor();

            return next(context);
        }
        public ConsoleLoggerMiddleware(IColor color)         //constructor kterému dáme jako parametr Dependency
        {
            Color = color;
            //Printer = printer;
        }
    }
}
