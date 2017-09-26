using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class PallidaClass
    {
        private string className;
        private List<Student> students;
        private List<Mentor> mentors;

        public PallidaClass(string className)
        {
            this.className = className;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", className, students.Count, mentors.Count);
        }
    }
}
