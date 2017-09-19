// Open a file called "my-file.txt"
// Write your name in it as a single line
// If the program is unable to write the file,
// then it should print an error message like: "Unable to write file: my-file.txt"

using System;
using System.IO;

namespace DailyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./my-file.txt";
            
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Reka");
                }
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content[0]);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}