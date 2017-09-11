using System;

namespace _06___CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyCodingHours = 6;
            int weeks = 17;
            int workDays = 5;
            int totalCodingHours = weeks * workDays * dailyCodingHours;
            double weeklyCodingHours = dailyCodingHours * workDays;
            double weeklyWorkHours = 52;
            double percentage = weeklyCodingHours / weeklyWorkHours;

            Console.WriteLine(totalCodingHours);
            Console.WriteLine(percentage);
            Console.ReadLine();
        }
    }
}
