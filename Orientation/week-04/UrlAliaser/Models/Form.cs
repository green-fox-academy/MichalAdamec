using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlAliaser.Models
{
    public class Form
    {
        public long Id { get; set; }
        [Key]
        public string Alias { get; set; }
        public string Url { get; set; }
        public string Code { get; set; }
        public int HitCount { get; set; } = 0;
    }
}
