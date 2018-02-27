using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models
{
    internal class ContextJsonModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "parameters")]
        public Dictionary<string, string> Parameters { get; set; }

        [JsonProperty(PropertyName = "lifespan")]
        public long Lifespan { get; set; }
    }
}
