using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Request
{

    internal class EntityUpdateRequestJsonModel : EntityCreateRequestJsonModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
