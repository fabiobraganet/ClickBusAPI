
namespace ClickBusAPI.Tests
{
    using ClickBusApi.Model.Base;
    using ClickBusAPI.Tests.Interfaces;
    using ClickBusAPI.Tests.Parameters;
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
                GetSession();
        }

        public static string SessionId { get; set; }

        private void GetSession()
        {
            var host = "https://api-evaluation.clickbus.com.br";
            var apiSession = RestService.For<ISessionsApiService>(host);

            var resultSession = apiSession
                .GetSessionAsync()
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();

            ReservarAssentosTests.SessionId = resultSession.Content;
        }

        [Fact]
        public async Task _01_ReservarAssentos()
        {
            var host = "https://api-evaluation.clickbus.com.br";

            var session = ReservarAssentosTests.SessionId;

            var api = RestService.For<ISeatBlockApiService>(host);

            var parameters = new SeatBlockPutFormParameters()
            {
                Meta = null,
                Request = new RequestContent<SeatBlockPutValues>()
                {
                    Request = new SeatBlockPutValues()
                    {
                        From = "Sao Paulo, SP - Tiete",
                        To = "Rio de Janeiro, RJ - Rodov. do Rio",
                        Seat = "07",
                        Passenger = new SeatBlockPutPassenger() 
                        {
                            Name = "Fulano da Silva",
                            Document = "12345678900",
                            DocumentType = "rg",
                            Gender = "M"
                        },
                        Schedule = new SeatBlockPutSchedule()
                        {
                            Id = "72aefe98-fe60-328f-8c25-542f7e931bf1",
                            Date = "2020-03-11",
                            Time = "00:15",
                            TimeZone = "America/Sao_Paulo"
                        },
                        SessionId = session
                    }
                }
            };

            try
            {
                var result = await api
                    .PutSeatBlockAsync(session, parameters)
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

            var api = RestService.For<ISeatBlockApiService>(host);

            var parameters = new SeatBlockPutFormParameters()
            {
                Meta = null,
                Request = new RequestContent<SeatBlockPutValues>()
                {
                    Request = new SeatBlockPutValues()
                    {
                        Seat = "05",
                        Schedule = new SeatBlockPutSchedule()
                        {
                            Id = "72aefe98-fe60-328f-8c25-542f7e931bf1",
                        },
                        SessionId = session
                    }
                }
            };

            try
            {

                var result = await api
                  .DeleteSeatBlockAsync(session, parameters)
                  .ConfigureAwait(false);

                //var notFoundPolicy = Policy
                //    .Handle<ApiException>(ex => ex.StatusCode == HttpStatusCode.NotFound)
                //    .RetryAsync(3, async (exception, retryCount) =>
                //        await Task.Delay(300).ConfigureAwait(false));

                //var badRequestPolicy = Policy
                //    .Handle<ApiException>(ex => ex.StatusCode == HttpStatusCode.BadRequest)
                //    .FallbackAsync(async (cancellationToken) => 
                //    {
                //        await Task.FromResult(true);
                //    }, 
                //    async (result) => 
                //    {
                //        //var x = (ApiException)result;
                //        await Task.FromResult(true);
                //    });

                //var result = await Policy
                //    .Handle<ApiException>(ex => ex.StatusCode == HttpStatusCode.RequestTimeout)
                //    .RetryAsync(3, async (exception, retryCount) => await Task.Delay(500))
                //    .WrapAsync(notFoundPolicy)
                //    .WrapAsync(badRequestPolicy)
                //    .ExecuteAsync(async () => 
                //    {
                //        return await api
                //          .DeleteSeatBlockAsync(session, parameters)
                //          .ConfigureAwait(false);
                //    })
                //    .ConfigureAwait(false);



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
