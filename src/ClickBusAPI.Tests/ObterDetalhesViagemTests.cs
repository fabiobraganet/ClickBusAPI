
namespace ClickBusAPI.Tests
{
    using ClickBusAPI.Tests.Interfaces;
    using Refit;
    using Xunit;

    public class ObterDetalhesViagemTests
    {
        [Fact]
        public void ObterDetalhesViagem()
        {
            var scheduleid = "72aefe98-fe60-328f-8c25-542f7e931bf1";

            var api = RestService.For<ITripDetailsApiService>("https://api-evaluation.clickbus.com.br");

            var result = api
                .GetTripDetailsAsync(scheduleid)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            Assert.True(result != null && result.Content != null, "É preciso haver o objeto com o content com uma unica viagem");

            if (result != null && result.Content != null)
            {
                Assert.True(!string.IsNullOrWhiteSpace(result.Content.TripId.ToString()), "É preciso ter um item no retorno");
                Assert.True(!string.IsNullOrWhiteSpace(result.Content.BusCompany.Name), "É preciso haver o objeto interno de viagem");

                if (result.Content.Seats != null
                    && result.Content.Seats.Count > 0)
                    Assert.True(!string.IsNullOrWhiteSpace(result.Content.Seats[0].Id.ToString()), "É preciso haver o id no objeto interno de Seats");
            }
        }
    }

}
