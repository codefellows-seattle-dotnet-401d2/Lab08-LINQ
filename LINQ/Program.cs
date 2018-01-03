using Newtonsoft.Json;
using System;
using System.IO;
using QuickType;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting the json file name to a variable
            string jsonFile = "data.json";
            string jsonData;

            //this way uses the variable we set!
            string path = Path.Combine(Environment.CurrentDirectory, @"..\", jsonFile);

            //This way uses the ABSOLUTE PATH, I can refactor this later to use one or the other to DRY it out
            using (StreamReader sr = File.OpenText(@"C:\Users\ZachAndChels\source\repos\Lab08-LINQ\data.json"))
            {
                jsonData = File.ReadAllText(path);
            }

            //This is the non-converted json
            var data = Neighborhoods.FromJson(jsonData);


            //this is the converted json, woo!
            var isThisThingOn = Neighborhoods.FromJson(jsonData);
            Console.WriteLine(isThisThingOn);
            Console.ReadLine();

            //this will grab everything from the json that isn't null!
            IEnumerable<Feature> allNeighborhoods = from raw in isThisThingOn.Features
                                                    where raw.Properties != null
                                                    select raw;

            
            //this foreach writes out all the hood names
            foreach (var raw in allNeighborhoods)
            {
                Console.WriteLine(raw.Properties.Neighborhood);
            }
            Console.ReadLine();

            //this LINQ query will get rid of anything that doesn't have a neighborhood name value, i.e. hoods.Properties.Neighborhood is an empty string
            //Can't use null for this, because technically an empty string isn't null
            IEnumerable<Feature> filterNoNameHoods = from hoods in allNeighborhoods
                                                     where hoods.Properties.Neighborhood != ""
                                                     select hoods;


            Console.WriteLine("---------BREAKLINE--------");
            //writing it out to make sure it works!
            foreach (var hoods in filterNoNameHoods)
            {
                Console.WriteLine(hoods.Properties.Neighborhood);
            }
            Console.ReadLine();

            // this lambda expression took a minute, make sure to read over the overloads and built in helper methods
            // so what's happening here is it's grouping everything by name, and then only grabbing the first instance of that name
            // then! we have a cleaned up list. I'm using the prefiltered no name LINQ call to build off of it.
            var noDupeHoods = filterNoNameHoods.GroupBy(hood => hood.Properties.Neighborhood).Select(firsthood => firsthood.First());

            Console.WriteLine("---------BREAKLINE-------");
            //writing again, to check it works as intended, we can move this stuff to TESTS soon
            foreach (var hoods in noDupeHoods)
            {
                Console.WriteLine(hoods.Properties.Neighborhood);
            }
            Console.ReadLine();

            // I tried for a half hour to do this with LINQ, and gave up when I realized it might be easier to do this with lambda.
            // So part one, we grab hoods where the name isn't equal to an empty string, then we group them by name, then we select the first!
            var endThis = allNeighborhoods.Where(x => x.Properties.Neighborhood != "").GroupBy(x => x.Properties.Neighborhood).Select(one => one.First());


            Console.WriteLine("---------------BREAKLINE---------------");

            // another test to implement
            foreach ( var rah in endThis)
            {
                
                Console.WriteLine(rah.Properties.Neighborhood);
   
            }

            Console.ReadLine();
        }
    }
}
