
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;

    public class Point
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("waypoint")]
        public Waypoint Waypoint { get; set; }
    }
}
