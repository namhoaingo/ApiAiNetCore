using ApiAiNetCore.Internal.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Responses
{
    internal class EntityListRespoonseJsonModel : IResponse, IFixList
    {
        [JsonProperty(PropertyName = "entities")]
        public IEnumerable<EntityJsonModel> Entities { get; set; }

        [JsonProperty(PropertyName = "status")]
        public StatusJsonModel Status { get; set; }

        public string ListFixFieldName => nameof(Entities);
    }
}
