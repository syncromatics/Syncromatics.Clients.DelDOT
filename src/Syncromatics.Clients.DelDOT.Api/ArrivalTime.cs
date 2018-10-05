using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncromatics.Clients.DelDOT.Api
{
    public class ArrivalTime
    {
        /*{
            "serviceAvailable": true,
            "busDetails": false,
            "destination": "Rehoboth Boardwalk",
            "busSchArrival": "06:00PM",
            "busSchCountdown": 4,
            "busEstArrival": "06:00PM",
            "busEstCountdown": 4,
            "tripId": "396616",
            "stopAlert": false
        }*/

        public bool ServiceAvailable { get; set; }
        public bool BusDetails { get; set; }
        public string Destination { get; set; }
        [JsonProperty("busEstCountdown")]
        public int EstimatedArrivalMinutes { get; set; }
        [JsonProperty("busSchCountdown")]
        public int ScheduledArrivalMinutes { get; set; }
        public string TripId { get; set; }
        public bool StopAlert { get; set; }
    }
}
