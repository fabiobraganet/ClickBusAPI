
namespace ClickBusApi.Model.TripDetails
{
    using Newtonsoft.Json;

    public class Position
    {
        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }

        [JsonProperty("z")]
        public string Z { get; set; }
    }
}
