
namespace ClickBusApi.Model.BusCompanies
{
    using ClickBusApi.Model.Base;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class BusCompaniesContent<T>
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("busCompanies")]
        public IList<T> Content { get; set; } = new List<T>();

    }
}
