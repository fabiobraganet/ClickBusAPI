
namespace ClickBusAPI.Tests.Interfaces
{
    using ClickBusApi.Model.BusCompanies;
    using Refit;
    using System.Threading.Tasks;
    
    public interface IBusCompaniesApiService
    {
        [Get("/api/v1/buscompanies")]
        Task<BusCompaniesContent<BusCompany>> GetAllBusCompaniesAsync();

        [Get("/api/v1/buscompanies/{id}")]
        Task<BusCompaniesContent<BusCompany>> GetBusCompanyAsync(string id);
    }
}
