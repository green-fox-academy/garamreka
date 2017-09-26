using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    public class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.", name, age, gender);
        }
        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
        
    }
}
