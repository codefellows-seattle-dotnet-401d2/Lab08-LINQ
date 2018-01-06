﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickTypes
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public partial class FeatureCollection
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public Feature[] Features { get; set; }
    }

    public partial class Feature
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }

    public partial class Properties
    {
        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("borough")]
        public string Borough { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }
    }

    public partial class Geometry
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public partial class FeatureCollection
    {
        public static FeatureCollection FromJson(string json) => JsonConvert.DeserializeObject<FeatureCollection>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FeatureCollection self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}