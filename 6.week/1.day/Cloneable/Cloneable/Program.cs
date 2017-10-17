using System;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John Doe", 20, "male", "BME");
            Student johnTheClone = (Student)john.Clone();

            john.Introduce();
            johnTheClone.Introduce();

            Console.ReadLine();
        }
    }
}
