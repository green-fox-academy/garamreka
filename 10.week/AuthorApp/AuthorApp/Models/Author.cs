using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorApp.Models
{
    public class Author
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string HomeCountry { get; set; }
        public string City { get; set; }
    }
}
