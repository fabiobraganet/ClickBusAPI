
namespace ClickBusApi.Model.SeatsBlocks
{
    using Newtonsoft.Json;

    public class SeatBlockDelete
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }
}
