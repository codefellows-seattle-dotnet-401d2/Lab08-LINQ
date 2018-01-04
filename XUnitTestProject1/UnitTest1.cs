using System;
using System.IO;
using Xunit;
using JSONThing;
using QuickTypes;
using Newtonsoft.Json;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        FeatureCollection Collection = LoadFeatures();

        [Fact]
        public void FeatureCollectionInstantiates()
        {
            Assert.Equal(147, Collection.Features.Length);
        }

        [Fact]
        public void FeatureCollectionSize()
        {
            Assert.NotEqual(148, Collection.Features.Length);
        }

        public static FeatureCollection LoadFeatures() =>
          JsonConvert.DeserializeObject<FeatureCollection>(File.ReadAllText("../../../../JSONThing/data.json"));
    }


}
