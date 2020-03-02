
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;

    public class Part
    {
        [JsonProperty("trip_id")]
        public string TripId { get; set; }

        [JsonProperty("departure")]
        public Point Departure { get; set; }

        [JsonProperty("arrival")]
        public Point Arrival { get; set; }

        [JsonProperty("busCompany")]
        public TripBusCompany BusCompany { get; set; }

        [JsonProperty("bus")]
        public Bus Bus { get; set; }

        [JsonProperty("availableSeats")]
        public string AvailableSeats { get; set; }
    }


}
