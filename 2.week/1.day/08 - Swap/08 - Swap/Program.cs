using System;

namespace _08___Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("New a is: " + a);
            Console.WriteLine("New b is: " + b);
            Console.ReadLine();
        }
    }
}
