
namespace ClickBusApi.Model.Base
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class Content<T>
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("items")]
        public IList<T> Items { get; set; } = new List<T>();

        [JsonProperty("busCompanies")]
        public IList<T> BusCompanies { get; set; } = new List<T>();
    }
}
