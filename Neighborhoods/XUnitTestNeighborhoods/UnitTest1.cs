using System;
using System.IO;
using Xunit;
using QuickType;
using System.Collections.Generic;
using System.Linq;

namespace XUnitTestNeighborhoods
{
    public class UnitTest1
    {
        [Fact]
        public void TestNumOfUniqueNeighborhoods()
        {
            string path = "../../../data.json";
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
            IEnumerable<string> allUniqueNeighborhoods = data.Features.Select(n => n.Properties.Neighborhood)
                                                                 .Where(n => n != "")
                                                                 .Distinct().OrderBy(n => n);
            int numOfHoods = allUniqueNeighborhoods.Count();
            Assert.Equal(39, numOfHoods);
        }
    }
}
