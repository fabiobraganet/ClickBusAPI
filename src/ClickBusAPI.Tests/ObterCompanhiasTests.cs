
namespace ClickBusAPI.Tests
{
    using ClickBusAPI.Tests.Interfaces;
    using Refit;
    using Xunit;

    public class ObterCompanhiasTests
    {
        [Fact]
        public void ObterCompanhias()
        {
            var api = RestService.For<IBusCompaniesApiService>("https://api-evaluation.clickbus.com.br");

            var result = api
                .GetAllBusCompaniesAsync()
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            Assert.True(result != null && result.Content.Count > 0, "É preciso haver o objeto e a lista de objetos");

            if (result != null && result.Content.Count > 0)
            {
                Assert.True(!string.IsNullOrWhiteSpace(result.Content[0].Id.ToString()), "O ID é requerido");
                Assert.True(!string.IsNullOrWhiteSpace(result.Content[0].Name.ToString()), "O Name é requerido");
            }
        }
    }

}
