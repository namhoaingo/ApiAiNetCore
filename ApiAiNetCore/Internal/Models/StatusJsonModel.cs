using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models
{

    internal class StatusJsonModel
    {
        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "errorType")]
        public string ErrorType { get; set; }

        [JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; set; }

        [JsonProperty(PropertyName = "errorDetails")]
        public string ErrorDetails { get; set; }
    }
}
