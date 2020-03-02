
namespace ClickBusApi.Model.TripDetails
{
    using Newtonsoft.Json;

    public class Seat
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avaliable")]
        public string Avaliable { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }
}
