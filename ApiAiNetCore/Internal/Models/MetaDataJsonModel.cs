using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models
{
    internal class MetadataJsonModel
    {
        [JsonProperty(PropertyName = "intentId")]
        public string IntentId { get; set; }

        [JsonProperty(PropertyName = "webhookUsed")]
        public string WebhookUsed { get; set; }

        [JsonProperty(PropertyName = "webhookForSlotFillingUsed")]
        public string WebhookForSlotFillingUsed { get; set; }

        [JsonProperty(PropertyName = "webhookResponseTime")]
        public double WebhookResponseTime { get; set; }

        [JsonProperty(PropertyName = "intentName")]
        public string IntentName { get; set; }
    }
}
