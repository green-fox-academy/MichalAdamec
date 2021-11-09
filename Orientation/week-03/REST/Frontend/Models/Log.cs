using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Create a log object which has the following fields:
//createdAt - date and time
//endpoint - string
//data - string

//Create a database table for storing log objects
//Modify your previous endpoints to save a log object
//where the createdAt will be the timestamp of the creation
//the endpoint will be the name of the endpoint that was used when the object was created
//the data will be received data (query params, received json data)
//Create a GET /log endpoint
//That responds with all the log entries from the database and the number of them

namespace Frontend.Models
{
    public class Log
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Endpoint { get; set; }
        public string Data { get; set; }
    }
}
