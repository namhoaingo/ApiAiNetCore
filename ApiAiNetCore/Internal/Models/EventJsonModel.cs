using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models
{
    internal class EventJsonModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "data")]
        public Dictionary<string, string> Data { get; set; }
    }
}
