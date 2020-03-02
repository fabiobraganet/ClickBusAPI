
namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model;
    using ClickBusApi.Model.Base;
    using ClickBusApi.Model.Trips;
    using ClickBusAPI.Tests.Parameters;
    using Refit;
    using System.Threading.Tasks;
    
    public interface ITripsApiService
    {
        //[Get("/api/v1/trips?from={From}&to={To}&departure={Departure}&engine={Engine}")]
        [Get("/api/v1/trips?from={parameters.from}&to={parameters.to}&departure={parameters.departure}")]
        Task<Content<Trip>> GetAllTripsAsync(GetAllTripsParameters parameters);
    }
}
