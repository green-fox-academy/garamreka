using System;

namespace _14___HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            Console.WriteLine("Hi, what is your name?");
            user = Console.ReadLine();
            Console.WriteLine("Hello " + user + "!");
            Console.ReadLine();
        }
    }
}
