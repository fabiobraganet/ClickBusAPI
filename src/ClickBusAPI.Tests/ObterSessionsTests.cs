
namespace ClickBusAPI.Tests
{
    using ClickBusAPI.Tests.Interfaces;
    using Refit;
    using Xunit;

    public class ObterSessionsTests
    {
        [Fact]
        public void ObterSessions()
        {
            var api = RestService.For<ISessionsApiService>("https://api-evaluation.clickbus.com.br");

            var result = api
                .GetSessionAsync()
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            Assert.True(result != null && !string.IsNullOrWhiteSpace(result.Content), "É preciso haver o objeto com a session");

        }

    }

}
