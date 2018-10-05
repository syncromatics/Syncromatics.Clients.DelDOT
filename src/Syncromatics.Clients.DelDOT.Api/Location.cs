using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncromatics.Clients.DelDOT.Api
{
    public class Location
    {
        [JsonProperty("y")]
        public double Latitude { get; set; }

        [JsonProperty("x")]
        public double Longitude { get; set; }
    }
}
