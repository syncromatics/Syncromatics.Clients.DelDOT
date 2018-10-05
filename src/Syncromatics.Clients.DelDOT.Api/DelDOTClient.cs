using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;

namespace Syncromatics.Clients.DelDOT.Api
{
    public class DelDOTClient : IDelDOTClient
    {
        private readonly IDelDOTClient _client;

        public DelDOTClient() 
            : this(new ClientSettings())
        {

        }

        public DelDOTClient(ClientSettings clientSettings)
        {
            var handler = new HttpClientHandler { MaxConnectionsPerServer = clientSettings.MaxConnections };
            var httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri(clientSettings.ServerRootUrl)
            };

            _client = new RestClient(httpClient).For<IDelDOTClient>();
        }

        public Task<StopArrivals> GetStopArrivalsAsync(int stopId)
        {
            return _client.GetStopArrivalsAsync(stopId);
        }
    }
}
