
namespace ClickBusApi.Model.Sessions
{
    using Newtonsoft.Json;

    public class SessionContent
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
