using System;
using Xunit;
using JSONThing;
using QuickTypes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void FeatureCollectionInstantiates()
        {
            FeatureCollection Collection = LoadFeatures();
        }
    }
}
