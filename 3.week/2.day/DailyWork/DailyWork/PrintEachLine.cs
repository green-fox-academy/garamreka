// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"

using System;
using System.IO;

namespace DailyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./my-file.txt";
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Hello Alpaga!");
            }

            try
            {
                String content = File.ReadAllLines(path);
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
