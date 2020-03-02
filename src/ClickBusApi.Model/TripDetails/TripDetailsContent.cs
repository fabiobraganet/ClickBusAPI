
namespace ClickBusApi.Model.TripDetails
{
    using ClickBusApi.Model.Base;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class TripDetailsContent<T>
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("content")]
        public T Content { get; set; }

    }
}
