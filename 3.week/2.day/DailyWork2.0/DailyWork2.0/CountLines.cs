// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.

using System;
using System.Linq;
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
                    int countLines = File.ReadAllLines(path).Count();
                    Console.WriteLine(countLines);
                }
                catch (Exception)
                {
                    Console.WriteLine("Can't open the file");
                }
                finally
                {
                    Console.ReadLine();
                }
        }
    }
}
