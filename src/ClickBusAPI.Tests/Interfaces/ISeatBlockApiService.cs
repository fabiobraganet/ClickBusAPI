

namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model.SeatsBlocks;
    using ClickBusAPI.Tests.Parameters;
    using Refit;
    using System.Threading.Tasks;

    public interface ISeatBlockApiService
    {
        [Put("/api/v1/seat-block")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task<ResponseContent<SeatBlock>> PutSeatBlockAsync([Header("cookie")] string cookie, [Body(BodySerializationMethod.Serialized)] SeatBlockPutFormParameters parameters);

        [Delete("/api/v1/seat-block")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task<ResponseDeletedContent<SeatBlock>> DeleteSeatBlockAsync([Header("PHPSESSID")] string cookie, [Body(BodySerializationMethod.Serialized)] SeatBlockPutFormParameters parameters);
    }
}
