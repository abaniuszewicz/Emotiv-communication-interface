using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class UpdateSessionParameter
    {
        [JsonProperty("cortexToken")]
        public string CortexToken { get; set; }
        [JsonProperty("session")]
        public string Session { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

        public UpdateSessionParameter(string cortexToken, string session, string status)
        {
            CortexToken = cortexToken;
            Session = session;
            Status = status;
        }
    }
}
