using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("\nCALCULATOR\n" +
                    "===========\n\n" +
                    "[operand] [operation] [operand]");
            }
            else if (args.Length !=3)
            {
                Console.WriteLine("Oh-oh, something is missing, please write again your data\n\n" +
                    "[operand][operation][operand]");
            }

            if (args.Contains("+"))
            {
                Console.WriteLine();
                Console.WriteLine(Calculation<decimal>.Add(args));
            }

            //else if (args.Contains("/"))
            //{
            //    Console.WriteLine(Calculation<double>.Divide(args));
            //}
            //else if (args.Contains("*"))
            //{
            //    Calculator<double>.Multiply(args);
            //}
            //else if (args.Contains("-"))
            //{
            //    Console.WriteLine(Calculation<decimal>.Substract(args));
            //}
        }
    }
}
