using System;
using Example;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Virheentarkastusharjotus");
            string fPath = string.Empty;
            //string fPath = @"C:\\temp\movie.Json";
            FileManager fileManager = new FileManager(@"C:\\temp\movie.Json");
            Console.WriteLine(fileManager.ReadWords());

        }
    }
}

