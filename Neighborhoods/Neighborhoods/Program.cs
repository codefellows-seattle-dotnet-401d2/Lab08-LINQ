using System;
using System.IO;
using QuickType;
using System.Collections.Generic;
using System.Linq;

namespace Neighborhoods
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "data.json";
            string jsonString = "";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        jsonString += s;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed reading file... " + e.Message);
                throw;
            }

            var data = Data.FromJson(jsonString);

            // 1. Output all of the neighborhoods in this data list
            Console.WriteLine("Output all of the neighborhoods in this data list.\n");
            IEnumerable<string> allNeighborhoods = data.Features.Select(n => n.Properties.Neighborhood);
            foreach (string name in allNeighborhoods) Console.WriteLine(name);
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            // 2. Filter out all the neighborhoods that do not have any names
            Console.WriteLine("Filter out all the neighborhoods that do not have any names.\n");
            IEnumerable<string> allHoodsWithNames = allNeighborhoods.Where(n => n != "");
            foreach (string name in allHoodsWithNames) Console.WriteLine(name);
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            // 3. Remove the Duplicates
            Console.WriteLine("Remove the Duplicates.\n");
            IEnumerable<string> allUniqueHoods = allHoodsWithNames.Distinct().OrderBy(n => n);
            foreach (string name in allUniqueHoods) Console.WriteLine(name);
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            // 4. Rewrite the queries from above, and consolidate all into one single query.
            Console.WriteLine("Rewrite the queries from above, and consolidate all into one single query.\n");
            IEnumerable<string> allHoodsMegaQuery = data.Features.Select(n => n.Properties.Neighborhood)
                                                                 .Where(n => n != "")
                                                                 .Distinct().OrderBy(n => n);
            foreach (string name in allHoodsMegaQuery) Console.WriteLine(name);
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();

            // 5. Rewrite at least one of these questions only using a LINQ query (without lambda statement) 
            Console.WriteLine("Rewrite at least one of these questions only using a LINQ query (without lambda statement).\n");
            IEnumerable<string> allHoodsMegaQuery2 = (from n in data.Features
                                                      where n.Properties.Neighborhood != ""
                                                      orderby n.Properties.Neighborhood
                                                      select n.Properties.Neighborhood).Distinct();
            foreach (string name in allHoodsMegaQuery2) Console.WriteLine(name);
            Console.WriteLine("Press Enter to continue...\n");
            Console.ReadLine();
        }
    }
}
