
namespace ClickBusAPI.Tests.Parameters
{
    using ClickBusApi.Model.Base;
    using Refit;

    public class RequestContent<T>
    {
        public T Request { get; set; }

    }

    public class SeatBlockPutFormParameters
    {
        [AliasAs("meta")]
        public Meta Meta { get; set; }

        [AliasAs("request")]
        public RequestContent<SeatBlockPutValues> Request { get; set; }

    }

    public class SeatBlockPutValues
    {
        [AliasAs("form")]
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
