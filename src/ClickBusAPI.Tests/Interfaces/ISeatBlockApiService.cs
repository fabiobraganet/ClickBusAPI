

namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model.SeatsBlocks;
    using ClickBusAPI.Tests.Parameters;
    using Refit;
    using System.Threading.Tasks;

    public interface ISeatBlockApiService
    {
        [Put("/api/v1/seat-block")]
        Task<ResponseContent<SeatBlock>> PutSeatBlockAsync([Header("PHPSESSID")] string cookie, SeatBlockPutFormParameters parameters);

        [Delete("/api/v1/seat-block")]
        Task<ResponseDeletedContent<SeatBlock>> DeleteSeatBlockAsync([Header("PHPSESSID")] string cookie, SeatBlockPutFormParameters parameters);
    }
}
