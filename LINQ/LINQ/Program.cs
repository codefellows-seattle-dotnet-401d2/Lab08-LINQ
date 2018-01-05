using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
class Program
{
    static void Main(string[] args)
    {
        //path
        string fileName = "data.json";
        string path = Path.Combine(Environment.CurrentDirectory, fileName);
        string jsonData;


        //using stream reader to read json file
        using (StreamReader sr = File.OpenText(path))
        {
            jsonData = File.ReadAllText(path);
            Console.WriteLine(jsonData);
            Console.ReadLine();
            Console.Clear();
        }

        //Deserializing Json in this file
        var data = LINQ.FromJson(jsonData);

        //Returning all data, unfiltered, in json string format
        IEnumerable<Feature> rawdata = from x in data.Features
                                       where x.Properties.Neighborhood != null
                                       select x;
        foreach (var x in rawdata)
        {
            Console.WriteLine(x.Properties.Neighborhood);
        }

        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();


        //Filtering out neighborhoods that are blank or have no names
        var noNameFilter = rawdata.Where(y => y.Properties.Neighborhood != "");
        foreach (var x in noNameFilter)
        {
            Console.WriteLine(x.Properties.Neighborhood);
        }

        Console.WriteLine();
        Console.ReadLine();
        Console.Clear();
    }


}
}

