using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class RequestAccessParameter
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("clientSecret")]
        public string ClientSecret { get; set; }

        public RequestAccessParameter(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}
