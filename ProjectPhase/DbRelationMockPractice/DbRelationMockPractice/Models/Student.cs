using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbRelationMockPractice.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public Address Address { get; set; }
        [JsonIgnore]
        public Grade Grade { get; set; }
    }
}
