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
        public async Task ShouldGetArrivals(int stopId)
        {
            var result = await _client.GetStopArrivalsAsync(stopId);

            result.Name.Should().NotBeNullOrWhiteSpace();
            result.RouteIds.Should().NotBeEmpty();
            result.StopId.Should().Be(stopId);
            result.Arrivals.Should().NotBeEmpty();

            result.Arrivals[0].Route.Should().NotBeEmpty();
            result.Arrivals[0].RouteTitle.Should().NotBeEmpty();
            result.Arrivals[0].ArrivalTimes.Should().NotBeEmpty();

            result.Arrivals[0].ArrivalTimes[0].TripId.Should().NotBeEmpty();
            result.Arrivals[0].ArrivalTimes[0].Destination.Should().NotBeEmpty();

            result.Arrivals[0].ArrivalTimes[0].ScheduledArrivalTime.ToLongTimeString()
                .Should().NotBeNullOrEmpty();

            var estArrivalTime = result.Arrivals[0].ArrivalTimes[0].EstimatedArrivalTime;
            if (estArrivalTime.HasValue)
            {
                estArrivalTime.Value.ToLongTimeString().Should().NotBeNullOrEmpty();
            }
        }
    }
}
