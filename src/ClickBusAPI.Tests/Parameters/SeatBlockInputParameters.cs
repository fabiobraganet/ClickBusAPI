
namespace ClickBusAPI.Tests.Parameters
{
    using Newtonsoft.Json;
    using Refit;

    public class SeatBlockMeta
    {
        [JsonProperty(PropertyName = "model")]
        public string Model { get; set; } = "Retail";

        [JsonProperty(PropertyName = "store")]
        public string Store { get; set; } = "Aarim";

        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; } = "API";

        [JsonProperty(PropertyName = "api_key")]
        public string ApiKey { get; set; } = "$2y$05$32207918184a424e2c8ccuyhYj9hvtm.6saALefnJynTnJsyEYSRy";
    }

    public class SeatBlockInputParameters
    {
        [JsonProperty(PropertyName = "meta")]
        public SeatBlockMeta Meta { get; set; }

        [JsonProperty(PropertyName = "request")]
        public SeatBlockPutValues Request { get; set; }

    }

    public class SeatBlockPutValues
    {
        [JsonProperty(PropertyName = "from")]
        public string From { get; set; }

        [JsonProperty(PropertyName = "to")]
        public string To { get; set; }

        [JsonProperty(PropertyName = "seat")]
        public string Seat { get; set; }

        [JsonProperty(PropertyName = "passenger")]
        public SeatBlockPutPassenger Passenger { get; set; }

        [JsonProperty(PropertyName = "schedule")]
        public SeatBlockPutSchedule Schedule { get; set; }

        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }
    }

    public class SeatBlockPutPassenger
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "document")]
        public string Document { get; set; }

        [JsonProperty(PropertyName = "documentType")]
        public string DocumentType { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string Gender { get; set; }
    }

    public class SeatBlockPutSchedule
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string TimeZone { get; set; }
    }
}
