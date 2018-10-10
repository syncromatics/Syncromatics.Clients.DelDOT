using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Syncromatics.Clients.DelDOT.Api.Tests.Integration
{
    public class DelDOTClientTests
    {
        private readonly DelDOTClient _client;

        public DelDOTClientTests()
        {
            _client = new DelDOTClient();
        }

        [Theory]
        [InlineData(3832)]
        [InlineData(3852)]
        [InlineData(560)]
        [InlineData(357)]
        [InlineData(673)]
        public async Task ShouldGetArrivals(int stopId)
        {
            var result = await _client.GetStopArrivalsAsync(stopId);

            result.Name.Should().NotBeNullOrWhiteSpace();
            result.RouteIds.Should().NotBeEmpty();
            result.StopId.Should().Be(stopId);
            result.Arrivals.Should().NotBeEmpty();

            foreach (var route in result.Arrivals)
            {
                route.Route.Should().NotBeEmpty();
                route.RouteTitle.Should().NotBeEmpty();

                if (route.ServiceAvailable)
                {
                    route.ArrivalTimes.Should().NotBeEmpty();

                    foreach (var arrival in route.ArrivalTimes)
                    {
                        arrival.TripId.Should().NotBeEmpty();
                        arrival.Destination.Should().NotBeEmpty();

                        arrival.ScheduledArrivalTime.Value.ToLongTimeString()
                            .Should().NotBeNullOrEmpty();

                        var estArrivalTime = arrival.EstimatedArrivalTime;
                        if (estArrivalTime.HasValue)
                        {
                            estArrivalTime.Value.ToLongTimeString().Should().NotBeNullOrEmpty();
                        }
                    }
                }
            }
        }
    }
}
