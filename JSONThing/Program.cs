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
            FeatureCollection Collection = LoadFeatures();

            Console.Write(Collection);
            Divider();

            List<String> Neighborhoods = new List<string>;
            foreach (var feature in Collection.Features)
            {
                string Neighborhood = feature.Properties.Neighborhood;
                if()
            }


            Console.Read();
        }

        public static FeatureCollection LoadFeatures() => 
            JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText("data.json"));

        public static void Divider() =>
            Console.WriteLine("+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+~+");
    }
    
}
