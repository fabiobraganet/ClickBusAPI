
namespace ClickBusAPI.Tests.Parameters
{
    using Refit;

    public class GetAllTripsParameters
    {
        [AliasAs("from")]
        public string From { get; set; }

        [AliasAs("to")]
        public string To { get; set; }

        [AliasAs("departure")]
        public string departure { get; set; }

        //[AliasAs("engine")]
        //public string engine { get; set; }

    }
}
