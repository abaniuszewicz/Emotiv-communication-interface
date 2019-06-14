using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class AuthorizeParameter
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("clientSecret")]
        public string ClientSecret { get; set; }
        [JsonProperty("license")]
        public string License { get; set; }
        [JsonProperty("debit")]
        public int? Debit { get; set; }

        public AuthorizeParameter(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
}
