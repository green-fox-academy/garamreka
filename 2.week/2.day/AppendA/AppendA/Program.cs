using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            Console.WriteLine(AppendA(am));
            Console.ReadLine();
        }

        public static string AppendA(string character)
        {
            character = character + "a";
            return character;
        }
    }
}
