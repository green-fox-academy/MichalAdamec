using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlAliaser.Models;

namespace UrlAliaser.Views.ViewModel
{
    public class MainViewModel
    {
        public Form Form { get; set; }
        public List<Form> list { get; set; }
        public string Text { get; set; } = string.Empty;


    }
}
