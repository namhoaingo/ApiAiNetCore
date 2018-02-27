using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models
{

    class FulfillmentJsonModel
    {
        [JsonProperty(PropertyName = "speech")]
        public string Speech { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public List<FulfillmentMessageJsonModel> Messages { get; set; }


    }
}
