
namespace ClickBusApi.Model.Places
{
    using Newtonsoft.Json;
    using System;

    public class PlaceItem
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("station_id")]
        public long StationId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_primary")]
        public string IsPrimary { get; set; }

        [JsonProperty("created_at")] 
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")] 
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }
    }
}
