
namespace ClickBusApi.Model.TripDetails
{
    using Newtonsoft.Json;
    
    public class Bus
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
