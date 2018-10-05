using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syncromatics.Clients.DelDOT.Api
{
    public class StopArrivals
    {
        /// <summary>
        /// Gets or sets the deldot internal stop id.
        /// </summary>
        [JsonProperty("id")]
        public string InternalId { get; set; }

        /// <summary>
        /// Gets or sets the deldot public stop identifier.  This is the key used in the api
        /// </summary>
        public int StopId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }


        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="StopArrivals"/> has bench.
        /// </summary>
        public bool Bench { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="StopArrivals"/> has a shelter.
        /// </summary>
        public bool Shelter { get; set; }

        /// <summary>
        /// Gets or sets the route ids servng this stop
        /// </summary>
        [JsonProperty("routeList")]
        public List<int> RouteIds { get; set; }

        [JsonProperty("arrivalTimes")]
        public List<RouteArrivals> Arrivals { get; set; }

        /// <summary>
        /// Gets or sets the last time this record was updated. (Most likely for arrivals)
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset Updated => DateTimeOffset.FromUnixTimeMilliseconds(UpdatedMilliseconds); 

        [JsonProperty("updated")]
        internal long UpdatedMilliseconds { get; set; }
    }
}
