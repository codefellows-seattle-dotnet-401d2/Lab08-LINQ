using System;
using Xunit;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
       
        [Fact]
        public void Return_All_Neighborhoods_Not_Empty()
        {
            // Sort
            StreamReader sr = new StreamReader("data.json");
            string json = sr.ReadToEnd();
            RootObject featuresCollection = JsonConvert.DeserializeObject<RootObject>(json);
            JsonDeserializer jd = new JsonDeserializer();

            // Act
            var result = jd.GetAllNeighborhoods(featuresCollection);

            // Assert
            Assert.NotEmpty(result);
        }
    }
}
