
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Trip
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("parts")]
        public List<Part> Parts { get; set; }
    }
}
