
namespace ClickBusApi.Model.SeatsBlocks
{
    using ClickBusApi.Model.Base;
    using Newtonsoft.Json;

    public class SeatBlockDeleteContent
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("content")]
        public SeatBlockDelete Content { get; set; }
    }
}
