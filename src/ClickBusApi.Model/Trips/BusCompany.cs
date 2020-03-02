
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;
    
    public class TripBusCompany
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

//        [JsonProperty("logo")]
//        public string Logo { get; set; }
    }
}
