
namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model.Sessions;
    using Refit;
    using System.Threading.Tasks;
    
    public interface ISessionsApiService
    {
        [Get("/api/v1/session")]
        Task<SessionContent> GetSessionAsync();

    }
}
