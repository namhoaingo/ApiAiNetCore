using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models.Request
{

    internal class QueryRequestJsonModel
    {
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        [JsonProperty(PropertyName = "event")]
        public EventJsonModel Event { get; set; }

        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        [JsonProperty(PropertyName = "lang")]
        public string Lang { get; set; }

        [JsonProperty(PropertyName = "contexts")]
        public ContextJsonModel Contexts { get; set; }

        [JsonProperty(PropertyName = "resetContexts")]
        public bool ResetContexts { get; set; }

        [JsonProperty(PropertyName = "entities")]
        public EntityJsonModel Entities { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone { get; set; }

        [JsonProperty(PropertyName = "location")]
        public LocationJsonModel Location { get; set; }

        [JsonProperty(PropertyName = "originalRequest")]
        public OriginalRequestJsonModel OriginalRequest { get; set; }
    }
}
