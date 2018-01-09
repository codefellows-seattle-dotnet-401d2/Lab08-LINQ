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
            var data = FeatureCollection.FromJson(jsonData);

            //return all neighborhoods
            Console.WriteLine("all of the hoods in this data list.\n");
            IEnumerable<string> rawData = data.Features.Select(n => n.Properties.Neighborhood);
            foreach (string name in rawData)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            //Filter out all the neighborhoods that do not have any names
            Console.WriteLine("Filtering ones that have blank spaces.\n");
            IEnumerable<string> allHoodsWithNames = rawData.Where(n => n != "");
            foreach (string name in allHoodsWithNames)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            //Removing the Duplicates.
            Console.WriteLine("Remove the Duplicates.\n");
            IEnumerable<string> allUniqueHoods = allHoodsWithNames.Distinct().OrderBy(n => n);
            foreach (string name in allUniqueHoods)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            //Querie Rewrite.
            Console.WriteLine("Querie Rewrite.\n");
            IEnumerable<string> allHoodsMegaQuery = data.Features.Select(n => n.Properties.Neighborhood).Where(n => n != "").Distinct().OrderBy(n => n);
            foreach (string name in allHoodsMegaQuery)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            //Rewrite at least one of these questions only using a LINQ query 
            Console.WriteLine("LINQ query.\n");
            IEnumerable<string> allHoodsMegaQuery2 = (from n in data.Features
                                                      where n.Properties.Neighborhood != ""
                                                      orderby n.Properties.Neighborhood
                                                      select n.Properties.Neighborhood).Distinct();
            foreach (string name in allHoodsMegaQuery2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();
        }
    }
}
