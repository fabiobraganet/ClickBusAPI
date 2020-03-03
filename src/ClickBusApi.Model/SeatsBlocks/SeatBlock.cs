
namespace ClickBusApi.Model.SeatsBlocks
{
    using Newtonsoft.Json;

    public class SeatBlock
    {
        [JsonProperty("seat")]
        public string Seat { get; set; }

        [JsonProperty("schedule")]
        public SeatBlockSchedule Schedule { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("expireAt")]
        public string ExpireAt { get; set; }
    }
}
