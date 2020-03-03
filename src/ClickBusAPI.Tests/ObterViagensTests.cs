
namespace ClickBusAPI.Tests
{
    using ClickBusAPI.Tests.Interfaces;
    using Refit;
    using Xunit;

    public class ObterViagensTests
    {
        [Fact]
        public void ObterViagens()
        {
            var api = RestService.For<ITripsApiService>("https://api-evaluation.clickbus.com.br");

            var parameters = new Parameters.GetAllTripsParameters()
            {
                From = "sao-paulo-sp-todos",
                To = "rio-de-janeiro-rj-todos",
                departure = "2020-03-11"
            };

            var result = api
                .GetAllTripsAsync(parameters)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            Assert.True(result != null && result.Items.Count > 0, "É preciso haver o objeto e a lista de objetos de viagem");

            if (result != null && result.Items.Count > 0)
            {
                Assert.True(!string.IsNullOrWhiteSpace(result.Items[0].From.ToString()), "É preciso haver ao menos um item no retorno");
                Assert.True(result.Items[0].Parts != null, "É preciso haver o objeto interno de viagem");

                if (result.Items[0].Parts != null
                    && result.Items[0].Parts.Count > 0)
                {
                    Assert.True(!string.IsNullOrWhiteSpace(result.Items[0].Parts[0].TripId.ToString()), "É preciso haver o id no objeto interno de part");
                }
            }
        }
    }

}
