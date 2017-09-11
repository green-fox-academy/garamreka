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
            double percentageNice = percentage * 100;

            Console.WriteLine("Total Coding Hours: " + totalCodingHours);
            Console.WriteLine("Percentage of coding during the week: " + percentageNice + "%");
            Console.ReadLine();
        }
    }
}
