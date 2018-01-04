using System;
using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fileName = "data.json";            
            string jsonData;

            string path = Path.Combine(Environment.CurrentDirectory, @"LINQ", fileName);

            using (StreamReader sr = File.OpenText("data.json"))
            {
                jsonData = File.ReadAllText(path);
            }
        }
    }

    
}

