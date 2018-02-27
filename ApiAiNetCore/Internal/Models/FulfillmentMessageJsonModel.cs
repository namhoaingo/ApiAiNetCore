using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiAiNetCore.Internal.Models
{
    class FulfillmentMessageJsonModel
    {

        [JsonProperty(PropertyName = "type")]
        public byte Type { get; set; }

        [JsonProperty(PropertyName = "speech")]
        public string Speech { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty(PropertyName = "buttons")]
        public List<object> Buttons { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "postback")]
        public string Postback { get; set; }

        [JsonProperty(PropertyName = "replies")]
        public List<string> Replies { get; set; }

        [JsonProperty(PropertyName = "payload")]
        public string Payload { get; set; }
    }
}
