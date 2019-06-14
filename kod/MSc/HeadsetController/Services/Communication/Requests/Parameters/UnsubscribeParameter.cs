using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class UnsubscribeParameter
    {
        [JsonProperty("cortexToken")]
        public string CortexToken { get; set; }
        [JsonProperty("session")]
        public string Session { get; set; }
        [JsonProperty("streams")]
        public IEnumerable<string> Streams { get; set; }

        public UnsubscribeParameter(string cortexToken, string session, IEnumerable<string> streams)
        {
            CortexToken = cortexToken;
            Session = session;
            Streams = streams;
        }
    }
}
