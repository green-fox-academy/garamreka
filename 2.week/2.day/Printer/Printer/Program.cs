using System;

namespace Printer
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] multiString = { "first", "second" };
            Console.WriteLine(Printer(args: multiString));
            Console.ReadLine();
        }

        public static void Printer(params string[] args)
        {
            Console.WriteLine(args);
           
        }
    }
}
