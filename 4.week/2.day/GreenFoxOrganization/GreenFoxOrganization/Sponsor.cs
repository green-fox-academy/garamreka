using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Sponsor : Person
    {
        string company;
        int hiredStudent;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
            hiredStudent = 0;
        }
        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudent = 0;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudent);
        }
        public void Hire()
        {
            hiredStudent++;
        }
        public new void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
