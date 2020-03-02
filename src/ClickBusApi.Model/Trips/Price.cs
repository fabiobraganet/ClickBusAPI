
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;

    public class Price
    {
        [JsonProperty("waypoint")]
        public string WayPoint { get; set; }

        [JsonProperty("price")]
        public string Cost { get; set; }
    }
}
