
namespace ClickBusApi.Model.Places
{
    using Newtonsoft.Json;

    public class Station
    {
        [JsonProperty("current")]
        public StationValue Current { get; set; }

        [JsonProperty("default")]
        public StationValue Default { get; set; }
    }

    public class StationValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

}
