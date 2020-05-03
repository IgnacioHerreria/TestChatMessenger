using Newtonsoft.Json;
using System;

namespace Utils.Chat.Dto
{
    public class DtoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("dt1")]
        public string Dt1 { get; set; }
        [JsonProperty("dt2")]
        public string Dt2 { get; set; }
        [JsonProperty("dt3")]
        public string Dt3 { get; set; }
        [JsonProperty("dt4")]
        public string Dt4 { get; set; }
    }
}
