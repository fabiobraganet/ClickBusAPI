
namespace ClickBusApi.Model.Places
{
    using Newtonsoft.Json;

    public class State
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
