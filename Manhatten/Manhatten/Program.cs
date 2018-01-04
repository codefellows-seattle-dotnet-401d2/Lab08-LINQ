using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

// Read in the file and answer the questions below
// Use LINQ queries and Lambda statements(when appropriate) to find the answers.

// SETUP
// TODO: Review what the possible Extension Methods are, and use them to answer the questions below?

// program only 
// put classes in program

//////
// in main
//string json = "";
//using streamreader

// outside of main, keep everything
// add queries
    // var question = linq queries with lambdas


namespace Manhatten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = "data.json";
          
                using (StreamReader sr = new StreamReader(path))
                {
                    string json = sr.ReadToEnd();

                    // Deserializing the json file using NewtonSoft Json tools
                    RootObject features = JsonConvert.DeserializeObject<RootObject>(json);

                    
                }
          
        

            Console.ReadLine();

        }

    }
}




