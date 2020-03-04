
namespace ClickBusAPI.Tests
{
    using ClickBusAPI.Tests.Interfaces;
    using Refit;
    using System.Threading.Tasks;
    using Xunit;

    public class ObterLocaisTests
    {
        [Fact]
        public async Task ObterTodosOsLocais()
        {
            var api = RestService.For<IPlacesApiService>("https://api-evaluation.clickbus.com.br");

            var result = await api.GetAllPlacesAsync().ConfigureAwait(false);

            Assert.True(result != null && result.Items.Count > 0, "É preciso haver o objeto e a lista de objetos de locais");

            if (result != null && result.Items.Count > 0)
            {
                Assert.True(!string.IsNullOrWhiteSpace(result.Items[0].Id.ToString()), "É preciso haver ao menos um item no retorno");
                Assert.True(result.Items[0].Place != null, "É preciso haver o objeto interno de locais");

                if (result.Items[0].Place != null)
                    Assert.True(!string.IsNullOrWhiteSpace(result.Items[0].Place.Id.ToString()), "É preciso haver o id no objeto interno de locais");
            }
        }
    }

}
