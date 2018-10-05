using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Syncromatics.Clients.DelDOT.Api
{
    public interface IDelDOTClient
    {
        [Get("mongodbsvc/stopdetails/{stopId}")]
        Task<StopArrivals> GetStopArrivalsAsync([Path]int stopId);
    }
}
