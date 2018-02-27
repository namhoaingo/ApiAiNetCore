using ApiAiNetCore.Internal.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Responses
{
    internal class QueryResponseJsonModel : IResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }

        [JsonProperty(PropertyName = "result")]
        public QueryResponseResultJsonModel Result { get; set; }

        [JsonProperty(PropertyName = "status")]
        public StatusJsonModel Status { get; set; }

        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }
    }

}
