using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int dailySeconds = 86400;
            int remainSeconds = dailySeconds - (currentSeconds + (currentMinutes * 60) + (currentHours * 3600));

            Console.WriteLine("Remaining seconds: " + remainSeconds);
            Console.ReadLine();
        }
    }
}
