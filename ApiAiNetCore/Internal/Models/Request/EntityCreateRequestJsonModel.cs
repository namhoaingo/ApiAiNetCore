using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Request
{
    internal class EntityCreateRequestJsonModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "entries")]
        public List<EntryJsonModel> Entries { get; set; }
    }
}
