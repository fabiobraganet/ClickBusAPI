
namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model.Base;
    using ClickBusApi.Model.Places;
    using Refit;
    using System.Threading.Tasks;
    
    public interface IPlacesApiService
    {
        [Get("/api/v1/places")]
        Task<Content<PlaceItem>> GetAllPlacesAsync();
    }
}
