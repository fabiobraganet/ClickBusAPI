

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
        Task<SeatBlockContent> PutSeatBlockAsync([Header("cookie")] string cookie, [Body(BodySerializationMethod.Serialized)] SeatBlockInputParameters parameters);

        [Delete("/api/v1/seat-block")]
        [Headers("Content-Type: application/json; charset=UTF-8")]
        Task<SeatBlockDeleteContent> DeleteSeatBlockAsync([Header("cookie")] string cookie, [Body(BodySerializationMethod.Serialized)] SeatBlockInputParameters parameters);
    }
}
