
namespace ClickBusAPI.Tests
{
    using ClickBusAPI.Tests.Interfaces;
    using Refit;
    using System.Threading.Tasks;
    using Xunit;

    public class ObterSessionsTests
    {
        [Fact]
        public async Task ObterSessions()
        {
            var api = RestService.For<ISessionsApiService>("https://api-evaluation.clickbus.com.br");

            var result = await api
                .GetSessionAsync()
                .ConfigureAwait(false);

            Assert.True(result != null && !string.IsNullOrWhiteSpace(result.Content), "É preciso haver o objeto com a session");

        }

    }

}
