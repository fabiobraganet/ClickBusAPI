
namespace ClickBusAPI.Tests
{
    using ClickBusApi.Model.Base;
    using ClickBusAPI.Tests.Interfaces;
    using ClickBusAPI.Tests.Parameters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using Polly;
    using Refit;
    using System.Net;
    using System.Threading.Tasks;
    using Xunit;

    public class ReservarAssentosTests
    {
        public ReservarAssentosTests()
        {
            if (string.IsNullOrWhiteSpace(ReservarAssentosTests.SessionId))
                GetSession().ConfigureAwait(false).GetAwaiter();
        }

        public static string SessionId { get; set; }

        private async Task<string> GetSession()
        {
            var host = "https://api-evaluation.clickbus.com.br";
            var apiSession = RestService.For<ISessionsApiService>(host);

            var resultSession = await apiSession
                .GetSessionAsync()
                .ConfigureAwait(false);

            //ReservarAssentosTests.SessionId = resultSession.Content;

            return resultSession.Content;
        }

        [Fact]
        public async Task _01_ReservarAssentos()
        {
            var host = "https://api-evaluation.clickbus.com.br";

            var session = await GetSession();//"badf1d58-a653-47df-9a8b-4969620544cb";

            var api = RestService.For<ISeatBlockApiService>(host);

            var parameters = new SeatBlockPutFormParameters()
            {
                Meta = new SeatBlockMeta(),
                Request = new SeatBlockPutValues()
                {
                    From = "Sao Paulo, SP - Tiete",
                    To = "Rio de Janeiro, RJ - Rodov. do Rio",
                    Seat = "04",
                    Passenger = new SeatBlockPutPassenger()
                    {
                        Name = "Fulano da Silva",
                        Document = "12345678900",
                        DocumentType = "rg",
                        Gender = "M"
                    },
                    Schedule = new SeatBlockPutSchedule()
                    {
                        Id = "6b0b02f3-b046-325f-a202-a5d6ad1067bf",
                        Date = "2020-03-05",
                        Time = "16:30",
                        TimeZone = "America/Sao_Paulo"
                    },
                    SessionId = session
                }
            };

            try
            {
                var result = await api
                    .PutSeatBlockAsync("PHPSESSID=" + session, parameters)
                    .ConfigureAwait(false);

                Assert.True(result != null && result.Request.Count > 0, "É preciso haver o objeto carregado");
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == HttpStatusCode.BadRequest)
                {
                    var error = await ex
                        .GetContentAsAsync<ErrorContent>()
                        .ConfigureAwait(false);

                    Assert.True(false, $"{error.Error[0].Code} {error.Error[0].Message}");
                }
                else
                {
                    Assert.True(false, ex.Message);
                }
            }
        }

        [Fact]
        public async Task _02_CancelarReservaDeAssentos()
        {
            var host = "https://api-evaluation.clickbus.com.br";

            var session = ReservarAssentosTests.SessionId;

            var api = RestService.For<ISeatBlockApiService>(host,
                settings: new RefitSettings
                {
                    ContentSerializer = new JsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        })
                });

            var parameters = new SeatBlockPutFormParameters()
            {
                Meta = null,
                Request = new SeatBlockPutValues()
                {
                    Seat = "04",
                    Schedule = new SeatBlockPutSchedule()
                    {
                        Id = "6b0b02f3-b046-325f-a202-a5d6ad1067bf",
                    },
                    SessionId = session
                }
            };

            try
            {

                var result = await api
                  .DeleteSeatBlockAsync(session, parameters)
                  .ConfigureAwait(false);

                Assert.True(result != null && result.Request.Status.ToLower() == "canceled", "É preciso retornar como reserva cancelada");
            }
            catch (ApiException ex)
            {
                if (ex.StatusCode == HttpStatusCode.BadRequest)
                {
                    var error = await ex
                        .GetContentAsAsync<ErrorContent>()
                        .ConfigureAwait(false);

                    Assert.True(false, $"{error.Error[0].Code} {error.Error[0].Message}");
                }
                else
                {
                    Assert.True(false, ex.Message);
                }
            }
        }

    }

}
