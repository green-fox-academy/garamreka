using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            Console.Write("Give me a divisor: ");
            int divisorByUser = int.Parse(Console.ReadLine());

            DivideByZero(divisorByUser);
        }
        public static void DivideByZero (int divisor)
        {
            try
            {
                double result = 10 / divisor;
                Console.WriteLine("Result is " + result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Fail");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
