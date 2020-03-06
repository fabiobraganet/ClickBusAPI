
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
        private async Task<string> GetSession()
        {
            var host = "https://api-evaluation.clickbus.com.br";
            var apiSession = RestService.For<ISessionsApiService>(host);

            var resultSession = await apiSession
                .GetSessionAsync()
                .ConfigureAwait(false);

            return resultSession.Content;
        }

        [Fact]
        public async Task TestarReservasDeAssentos()
        {
            var host = "https://api-evaluation.clickbus.com.br";
            var session = await GetSession();

            await _01_ReservarAssentos(host, session);
            await _02_CancelarReservaDeAssentos(host, session);
        }

        private async Task _01_ReservarAssentos(string host, string session)
        {
            var api = RestService.For<ISeatBlockApiService>(host,
                settings: new RefitSettings
                {
                    ContentSerializer = new JsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        })
                });

            var parameters = new SeatBlockInputParameters()
            {
                Meta = new SeatBlockMeta(),
                Request = new SeatBlockPutValues()
                {
                    From = "Sao Paulo, SP - Tiete",
                    To = "Rio de Janeiro, RJ - Rodov. do Rio",
                    Seat = "42",
                    Passenger = new SeatBlockPutPassenger()
                    {
                        Name = "Fulano da Silva",
                        Document = "12345678900",
                        DocumentType = "rg",
                        Gender = "M"
                    },
                    Schedule = new SeatBlockPutSchedule()
                    {
                        Id = "ca3b839f-ac05-39d3-9252-12f150a927c0",
                        Date = "", //"2020-03-05",
                        Time = "", //"16:30",
                        TimeZone = "" //"America/Sao_Paulo"
                    },
                    SessionId = session
                }
            };

            try
            {
                var result = await api
                    .PutSeatBlockAsync("PHPSESSID=" + session, parameters)
                    .ConfigureAwait(false);

                Assert.True(result != null, "É preciso haver o objeto carregado");
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

        private async Task _02_CancelarReservaDeAssentos(string host, string session)
        {
            var api = RestService.For<ISeatBlockApiService>(host,
                settings: new RefitSettings
                {
                    ContentSerializer = new JsonContentSerializer(
                        new JsonSerializerSettings
                        {
                            ContractResolver = new CamelCasePropertyNamesContractResolver()
                        })
                });

            var parameters = new SeatBlockInputParameters()
            {
                Meta = new SeatBlockMeta(),
                Request = new SeatBlockPutValues()
                {
                    Seat = "42",
                    Schedule = new SeatBlockPutSchedule()
                    {
                        Id = "ca3b839f-ac05-39d3-9252-12f150a927c0",
                    },
                    SessionId = session
                }
            };

            try
            {
                var result = await api
                  .DeleteSeatBlockAsync("PHPSESSID=" + session, parameters)
                  .ConfigureAwait(false);

                Assert.True(result != null && result.Content != null && result.Content.Status.ToLower() == "canceled", "É preciso retornar como reserva cancelada");
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
