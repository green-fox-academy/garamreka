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

            Console.ReadLine();
        }
    }
}
