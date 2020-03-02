
namespace ClickBusApi.Model.TripDetails
{
    using Newtonsoft.Json;
    
    public class TripDetailsBusCompany
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}