using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using QuickTypes;

namespace JSONThing
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.Write(Collection);

            Console.Read();
        }

        public FeatureCollection LoadFeatures()
        {
            return JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText("data.json"));
        }
    }
    
}
