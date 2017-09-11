using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 81.2;
            double heightInM = 1.78;
            double BMI = massInKg / (heightInM * heightInM);
            Console.WriteLine("BMI is: " + BMI);
            Console.ReadLine();
        }
    }
}
