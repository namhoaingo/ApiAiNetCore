using ApiAiNetCore.Internal.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Responses
{
    internal class EntriesResponseJsonModel : IResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "entries")]
        public List<EntryJsonModel> Entries { get; set; }

        [JsonProperty(PropertyName = "isEnum")]
        public bool IsEnum { get; set; }

        [JsonProperty(PropertyName = "automatedExpansion")]
        public bool AutomatedExpansion { get; set; }

        [JsonProperty(PropertyName = "status")]
        private StatusJsonModel _status { get; set; }

        [JsonIgnore]
        public StatusJsonModel Status
        {
            get => (_status ?? new StatusJsonModel { Code = 200, ErrorDetails = "No status response" });
            set => _status = value;
        }
    }
}
