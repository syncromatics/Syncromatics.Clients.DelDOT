using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncromatics.Clients.DelDOT.Api
{
    public class RouteArrivals
    {
        /*{
            "routeId": "201",
            "serviceAvailable": true,
            "title": "Route 201 (Red Line - Rehoboth Beach)",
            "route": "201",
            "routeNo": 201,
            "arrivalTimes": Array[5]
        }*/

        [JsonProperty("routeNo")]
        public int RouteId { get; set; }

        public string Route { get; set; }

        public bool ServiceAvailable { get; set; }

        /// <summary>
        /// Gets or sets the route title. EG "Route 043 (Middletown/Odessa Park & Ride)",
        /// </summary>
        [JsonProperty("title")]
        public string RouteTitle { get; set; }

        public List<ArrivalTime> ArrivalTimes { get; set; }
    }
}
