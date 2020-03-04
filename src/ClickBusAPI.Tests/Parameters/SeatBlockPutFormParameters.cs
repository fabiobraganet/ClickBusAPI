
namespace ClickBusAPI.Tests.Parameters
{
    using Refit;

    public class RequestContent<T>
    {
        public T Request { get; set; }

    }

    //"meta": { "model": "Retail", "store": "Aarim", "platform": "API", "api_key": "$2y$05$32207918184a424e2c8ccuyhYj9hvtm.6saALefnJynTnJsyEYSRy" }
    public class SeatBlockMeta
    {
        [AliasAs("model")]
        public string Model { get; set; } = "Retail";

        [AliasAs("store")]
        public string Store { get; set; } = "Aarim";

        [AliasAs("platform")]
        public string Platform { get; set; } = "API";

        [AliasAs("api_key")]
        public string ApiKey { get; set; } = "$2y$05$32207918184a424e2c8ccuyhYj9hvtm.6saALefnJynTnJsyEYSRy";
    }

    public class SeatBlockPutFormParameters
    {
        [AliasAs("meta")]
        public SeatBlockMeta Meta { get; set; }

        [AliasAs("request")]
        public RequestContent<SeatBlockPutValues> Request { get; set; }

    }

    public class SeatBlockPutValues
    {
        [AliasAs("from")]
        public string From { get; set; }

        [AliasAs("to")]
        public string To { get; set; }

        [AliasAs("seat")]
        public string Seat { get; set; }

        [AliasAs("passenger")]
        public SeatBlockPutPassenger Passenger { get; set; }

        [AliasAs("schedule")]
        public SeatBlockPutSchedule Schedule { get; set; }

        [AliasAs("sessionId")]
        public string SessionId { get; set; }
    }

    public class SeatBlockPutPassenger
    {
        [AliasAs("name")]
        public string Name { get; set; }

        [AliasAs("document")]
        public string Document { get; set; }

        [AliasAs("documentType")]
        public string DocumentType { get; set; }

        [AliasAs("gender")]
        public string Gender { get; set; }
    }

    public class SeatBlockPutSchedule
    {
        [AliasAs("id")]
        public string Id { get; set; }

        [AliasAs("date")]
        public string Date { get; set; }

        [AliasAs("time")]
        public string Time { get; set; }
        
        [AliasAs("timezone")]
        public string TimeZone { get; set; }
    }
}
