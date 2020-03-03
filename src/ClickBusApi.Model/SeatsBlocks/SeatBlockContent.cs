
namespace ClickBusApi.Model.SeatsBlocks
{
    using ClickBusApi.Model.Base;
    using Newtonsoft.Json;

    public class SeatBlockContent
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("items")]
        public ResponseContent<SeatBlock> Items { get; set; }
    }
}
