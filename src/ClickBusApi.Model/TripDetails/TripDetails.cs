
namespace ClickBusApi.Model.TripDetails
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class TripDetails
    {
        [JsonProperty("trip_id")]
        public string TripId { get; set; }

        [JsonProperty("busCompany")]
        public TripDetailsBusCompany BusCompany { get; set; }

        [JsonProperty("bus")]
        public Bus Bus { get; set; }

        [JsonProperty("seats")]
        public List<Seat> Seats { get; set; }
    }
}
