using ApiAiNetCore.Internal.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Responses
{
    internal class EntityCreateResponseModel : IResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "status")]
        public StatusJsonModel Status { get; set; }
    }
}
