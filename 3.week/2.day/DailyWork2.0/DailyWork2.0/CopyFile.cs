// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful

using System;
using System.IO;

namespace DailyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "my-file.txt";
            string sourcePath = @"F:\GreenFox\garamreka\3.week\2.day\DailyWork2.0\DailyWork2.0\bin\Debug";
            string targetPath = @"F:\greenfox\garamreka\3.week\2.day\DailyWork2.0";
            string sourceFile = Path.Combine(sourcePath, fileName);
            string targetFile = Path.Combine(targetPath, fileName);

            try
            {
                CopyFile(sourceFile, targetFile);
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

        public static void CopyFile(string source, string target)
        {
            File.Copy(source, target, true);

            if (File.Exists(target))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false); ;
            }


        }
    }
}