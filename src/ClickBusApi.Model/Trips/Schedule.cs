
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;

    public class Schedule
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("date")]
        public string Date { get; set; }
        
        [JsonProperty("time")]
        public string Time { get; set; }
        
        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }
}
