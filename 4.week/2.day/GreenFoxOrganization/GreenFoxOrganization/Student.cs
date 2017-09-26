using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }
        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }
        public void SkipDays(int numbersOfDays)
        {
            skippedDays += numbersOfDays;
        }
    }
}
