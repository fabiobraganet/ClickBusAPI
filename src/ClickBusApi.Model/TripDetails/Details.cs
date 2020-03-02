
namespace ClickBusApi.Model.TripDetails
{
    using Newtonsoft.Json;

    public class Details
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
