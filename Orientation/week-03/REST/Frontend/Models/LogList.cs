using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class LogList
    {
        public Log Log { get; set; }
        public long LogsCount { get; set; }
        public List<Log> ListOfLogs { get; set; }
    }

}
