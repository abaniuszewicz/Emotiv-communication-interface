using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class CreateSessionParameter
    {
        [JsonProperty("cortexToken")]
        public string CortexToken { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("headset")]
        public string Headset { get; set; }

        public CreateSessionParameter(string cortexToken, string status)
        {
            CortexToken = cortexToken;
            Status = status;
        }
    }
}
