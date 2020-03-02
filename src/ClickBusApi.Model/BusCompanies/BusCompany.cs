
namespace ClickBusApi.Model.BusCompanies
{
    using Newtonsoft.Json;
    
    public class BusCompany
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public Logo Logo { get; set; }
    }
}
