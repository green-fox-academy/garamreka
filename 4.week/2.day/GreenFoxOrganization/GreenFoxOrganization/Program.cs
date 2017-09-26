using System;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mark = new Person("Mark", 46, "male");
            mark.Introduce();
            mark.GetGoal();
            Person jane = new Person();
            jane.Introduce();
            Student john = new Student("John Doe", 20, "male", "BME");
            john.Introduce();
            john.GetGoal();
            Student student = new Student();
            student.Introduce();
            Mentor gandhi = new Mentor("Gandhi", 148, "male", "senior");
            gandhi.Introduce();
            gandhi.GetGoal();
            Mentor mentor = new Mentor();
            mentor.Introduce();
            Sponsor sponsor = new Sponsor();
            sponsor.Introduce();
            Sponsor elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            elon.Introduce();
            elon.GetGoal();

            Console.ReadLine();
        }
    }
}
