using System;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person();
            test.Introduce();
            Person mark = new Person("Mark", 46, "male");
            mark.Introduce();
            mark.GetGoal();
            Student john = new Student("John Doe", 20, "male", "BME");
            john.Introduce();
            john.GetGoal();
            Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior");
            gandhi.Introduce();

            Console.ReadLine();
        }
    }
}
