using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbRelationMockPractice.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public int StudentId { get; set; }

        [JsonIgnore]
        public Student Student { get; set; }
    }
}
