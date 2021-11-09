using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime DateTime { get; set; }
        public int Votes { get; set; } = 0;
    }
}
