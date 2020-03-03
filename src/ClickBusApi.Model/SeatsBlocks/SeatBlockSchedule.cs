using System;
using System.Collections.Generic;
using System.Text;

namespace ClickBusApi.Model.SeatsBlocks
{
    using Newtonsoft.Json;

    public class SeatBlockSchedule
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
