
namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model.TripDetails;
    using Refit;
    using System.Threading.Tasks;

    public interface ITripDetailsApiService
    {
        [Get("/api/v1/trip?scheduleId={scheduleid}")]
        Task<TripDetailsContent<TripDetails>> GetTripDetailsAsync(string scheduleid);
    }
}
