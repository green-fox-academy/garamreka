using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 52;
            double heightInM = 1.62;
            Console.WriteLine("My BMI is: " + massInKg / (heightInM * heightInM));
            Console.ReadLine();
        }
    }
}
