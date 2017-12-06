using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbRelationMockPractice.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GrandeName { get; set; }
        public string GradeAnimal { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
