
namespace ClickBusApi.Model.Trips
{
    using Newtonsoft.Json;
    using System;

    public class Place
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("place_id")]
        public long PlaceId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("latitude")]
        public float Latitude { get; set; }

        [JsonProperty("longitude")]
        public float Longitude { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("station")]
        public Station Station { get; set; }
    }
}
