using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTpractice.Models
{
    public class Log
    {
        public DateTime CreatedAt { get; set; }
        public string Endpoint { get; set; }
        public string Data { get; set; }
    }
}
