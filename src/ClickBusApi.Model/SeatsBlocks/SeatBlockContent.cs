﻿
namespace ClickBusApi.Model.SeatsBlocks
{
    using ClickBusApi.Model.Base;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class SeatBlockContent
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("items")]
        public List<SeatBlock> Items { get; set; }
    }
}
