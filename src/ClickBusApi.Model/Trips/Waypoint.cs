
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Waypoint
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("prices")]
        public List<Price> Prices { get; set; }

        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("isdeparture")]
        public string IsDeparture { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }
    }
}
