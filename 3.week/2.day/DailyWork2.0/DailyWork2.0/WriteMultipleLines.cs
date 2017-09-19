// Create a function that takes 3 parameters: a path, a word and a number,
// than it should write to a file.
// The path parameter should be a string, that describes the location of the file.
// The word parameter should be a string, that will be written to the file as lines
// The number paramter should describe how many lines the file should have.
// So if the word is "apple" and the number is 5, than it should write 5 lines
// to the file and each line should be "apple"
// The function should not raise any error if it could not write the file.

using System;
using System.IO;

namespace DailyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = @"./my-file.txt";
            string myWord = "kiscica";
            int lines = 5;

            WriteLines(myPath, myWord, lines);
            string[] rows = File.ReadAllLines(myPath);

            foreach (var row in rows)
            {
                Console.WriteLine(row);
            }
        }

        public static void WriteLines(string path, string word, int number)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);
                    }
                }
                
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
