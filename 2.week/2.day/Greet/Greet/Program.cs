using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            Console.WriteLine(Greet(al));
            Console.ReadLine();
        }

        public static string Greet(string user)
        {
            user = "Greetings dear, " + user;
            return user;
        }
    }
}
